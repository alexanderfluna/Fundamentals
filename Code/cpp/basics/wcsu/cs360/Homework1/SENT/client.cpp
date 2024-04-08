// Alexander Luna | Problem 1

#define _CRT_SECURE_NO_WARNINGS
#include <windows.h>
#include <iostream>
#include <stdio.h>
#include <string>
#include <random>
#include <thread>
#include <unordered_map>

char generateRandomChar();
int generateRandomNumber();
void openMailSlot();
void openRingBuffer();
void waitForEvent();

// Player class to handle the player's information
struct Player {
	// Player's name
	std::string playerName;

	// Player's id
	char playerId;

	// Maps player's name to player's id
	std::unordered_map<std::string, char> playerNamesAndIds;
};
Player player;

// This is a memory overlay defining the structure of the buffer
typedef struct
{
	unsigned char  capacity;
	unsigned char  tail;
	unsigned char  head;
	unsigned char  buffer;
} CircularBuffer;

// Define the constants determining the shared memory parameters
// This is the size of the shared memory buffer
constexpr auto SHARED_MEMORY_SIZE = 100;

// This boolean is set to true once the Event is
// signaled so the ring buffer knows to shut down
bool moribund = false;

int main()
{
	// Prompt user via command line for player's name
	std::cout << "What is the player's name?\n";
	std::getline(std::cin, player.playerName);

	// Generates the player's id
	player.playerId = generateRandomChar();
	printf("The player's id is: %c\n", player.playerId);
	std::cout << "The player's id is " << sizeof(player.playerId) << " byte " << std::endl;

	// Insert player's name and player's id to map
	player.playerNamesAndIds[player.playerName] = player.playerId;

	// Sends player's name and player's id to server
	std::thread mailSlot(openMailSlot);
	system("pause");

	// Creates thread to handle waiting for the event
	std::thread eventThread(waitForEvent);

	// Creates thread to handle sending guesses to the Ring Buffer
	std::thread ringBufferThread(openRingBuffer);

	// Wait for threads to finish before continuing
	eventThread.join();
	ringBufferThread.join();
	mailSlot.join();

	printf("\nWhoopee! We guessed the right number!\n");
	
	return 0;
}

// Choose a random upperccae letter
// https://en.cppreference.com/w/cpp/numeric/random
char generateRandomChar()
{
	std::random_device rd;
	std::mt19937 gen(rd());
	std::uniform_int_distribution<int> dis('A', 'Z');

	return static_cast<char>(dis(gen));
}

// Choose a random number in the range of 0 to 255
// https://en.cppreference.com/w/cpp/numeric/random
int generateRandomNumber()
{
	std::random_device r;
	std::default_random_engine e1(r());
	std::uniform_int_distribution<int> uniform_dist(0, 255);
	int number = uniform_dist(e1);
	return number;
}

// Opens the MailSlot to open communicate between the client and server
void openMailSlot()
{

	// Define our Mailslot
	LPCWSTR szMailslot = L"\\\\*\\mailslot\\ExampleMailslot";

	// Define a buffer for holding messages
	constexpr auto BUFFER_LENGTH = 1024;
	char writeBuffer[BUFFER_LENGTH] = { 0 };
	DWORD bytesWritten;
	bool bResult;

	// Open the Mailslot
	HANDLE hMailslot = CreateFileW(
		szMailslot,					// This is the name of our Mailslot
		GENERIC_WRITE,				// We need to be able to write to it.
		FILE_SHARE_READ,			// This is required of all Mailslots
		NULL,						// Use the default security attributes
		OPEN_EXISTING,				// Well, duh!
		FILE_ATTRIBUTE_NORMAL,		// Use the normal file attributes
		NULL						// There is no template file
	);

	if (hMailslot == INVALID_HANDLE_VALUE)
	{
		printf("There was an error opening the Mailslot: %lu\n", GetLastError());
		exit(1);
	}

	// We successfully opened the Mailslot. Send some messages!
	printf("Sending name and player id.\n");
	int sequence = 0;
	// Iterate through players map
	for (const auto& pair : player.playerNamesAndIds)
	{
		// Sends player name, sequence #, and player id
		sprintf(writeBuffer, "%s sequence %d %c", pair.first.c_str(), sequence++, pair.second);
		size_t bytesToWrite = strlen(writeBuffer) + 1;
		bResult = WriteFile(hMailslot, writeBuffer, bytesToWrite, &bytesWritten, NULL);
		if (!bResult || (bytesWritten != bytesToWrite))
		{
			printf("An error occurred sending message %s: error code %lu\n", writeBuffer, GetLastError());
			CloseHandle(hMailslot);
		}
	}

	// Keeps mailslot alive until event has been signalled
	while (true)
	{
		if (moribund)
		{
			// Now send the message "quit" so the server exits gracefully
			sprintf(writeBuffer, "%s", "quit");
			size_t bytesToWrite = strlen(writeBuffer) + 1;
			bResult = WriteFile(hMailslot, writeBuffer, bytesToWrite, &bytesWritten, NULL);
			if (!bResult || (bytesWritten != bytesToWrite))
			{
				printf("An error occurred sending message %s: error code %lu\n", writeBuffer, GetLastError());
			}
			printf("Sent quit message. Closing mailslot.\n");
			CloseHandle(hMailslot);
			break;
		}
	}
}

void openRingBuffer()
{
	// Open the semaphore we will use to control access. It must have been already created.
	HANDLE hSemaphore = OpenSemaphore(SEMAPHORE_ALL_ACCESS,
		false,
		TEXT("SharedMemorySemaphore"));
	if (hSemaphore == INVALID_HANDLE_VALUE)
	{
		printf("An error occurred opening the semaphore: %lu\n", GetLastError());
		exit(1);
	}

	// Open the Shared Memory object. It must already have been created.
	HANDLE hMemory = OpenFileMapping(FILE_MAP_ALL_ACCESS,
		false,
		TEXT("ShareMemoryBuffer"));
	if (hMemory == INVALID_HANDLE_VALUE || hMemory == nullptr)
	{
		printf("An error occurred created the shared memory buffer:%lu\n", GetLastError());
		CloseHandle(hSemaphore);
		exit(1);
	}

	// Create the memory mapping and ...
	auto pBuffer = (unsigned char*)MapViewOfFile(hMemory,
		FILE_MAP_ALL_ACCESS,
		0,
		0,
		SHARED_MEMORY_SIZE);
	if (!pBuffer)
	{
		printf("An error occurred mapping the shared memory: %lu\n", GetLastError());
		CloseHandle(hSemaphore);
		CloseHandle(hMemory);
	}

	// ... overlay the circular memory structure.
	auto pCircularBuffer = (CircularBuffer*)pBuffer;

	// This is the index of the 'next' item in the circular buffer to be filled
	// We'll use it to determine when the buffer is full.
	int next;

	// This is the guess we'll be sending
	unsigned char guess = 0;

	// Loop until we've sent the correct guess
	printf("All set and ready to send guesses to the server.\n");
	while (!moribund)
	{
		// First get the semaphore. Wait for up to 100 milliseconds.
		DWORD dwWaitResult = WaitForSingleObject(hSemaphore, 100);

		// Check if the semaphore was signalled.
		switch (dwWaitResult)
		{
		case WAIT_OBJECT_0:

			// The semaphore was signalled.
			// Try to put our guess into the buffer. This should succeed unless
			// the buffer is already full.

			// This is where the 'next' item will go.
			next = (pCircularBuffer->head + 1) % pCircularBuffer->capacity;

			// Check if the buffer is already full.
			if (next == pCircularBuffer->tail)
			{
				// The buffer is already full. Wait a bit and try again.
			}
			else
			{
				// The buffer is not yet full. Store the guess.
				(&pCircularBuffer->buffer)[pCircularBuffer->head] = guess; // Store player's ID
				(&pCircularBuffer->buffer)[pCircularBuffer->head + 1] = player.playerId; // Store guess
				printf("Just sent guess (%d) for player (%c)\n", guess, player.playerId);

				guess = generateRandomNumber();

				// Update the head of the buffer
				pCircularBuffer->head = next;

				// Sleep for .06s
				std::this_thread::sleep_for(std::chrono::nanoseconds(60000000));
			}

			// Release the semaphore so another process may proceed.
			if (!ReleaseSemaphore(hSemaphore, 1, nullptr))
			{
				printf("Failed to release semaphore!: %lu\n", GetLastError());
			}
			break;

		case WAIT_TIMEOUT:
			// The semaphore timed out. This shouldn't happen since we are 
			// only writing to the buffer. This probably indicates that the
			// receiving end has exited for some reason.
			break;

		default:
			break;
		}
	}

	// Closes the semaphore and Shared Memory object
	printf("The correct guess has been sent! \nClosing Ring Buffer.\n");
	CloseHandle(hSemaphore);
	CloseHandle(hMemory);
}

void waitForEvent()
{
	// Set up security descriptor with a null access control list.
	// This will allow any other process to access this event.
	auto psd
		= (PSECURITY_DESCRIPTOR)LocalAlloc(LPTR, SECURITY_DESCRIPTOR_MIN_LENGTH);
	InitializeSecurityDescriptor(psd, SECURITY_DESCRIPTOR_REVISION);
	SetSecurityDescriptorDacl(psd, // Our security descriptor
		TRUE,    // Is the ACL present?
		nullptr,    // The ACL, null in this case
		FALSE);  // The ACL is set by hand.

	// Now set up a security attributes structure and ...
	SECURITY_ATTRIBUTES sa = { 0 };
	sa.nLength = sizeof(sa);

	// ... set it up to use security descriptor.
	sa.lpSecurityDescriptor = psd;
	sa.bInheritHandle = FALSE;

	// Create our event. We create it as a manual reset event.
	// An auto reset event is unsignalled after the first process
	// waiting for it processes it.
	HANDLE hEvent = CreateEvent(
		&sa,	// Use our security attributes structure
		true,	// Manual-reset mode
		false,	// Initially unsignalled
		TEXT("SampleEvent")
	);
	if (hEvent == INVALID_HANDLE_VALUE)
	{
		printf("Creating the event failed!: %lu\n", GetLastError());
		exit(1);
	}

	bool successfullySignaled = false;
	DWORD dwWaitResult = WaitForSingleObject(hEvent, INFINITE);
	switch (dwWaitResult)
	{
		// The Event was signaled
	case WAIT_OBJECT_0:
		printf("\nThe Event was signaled.\n");
		successfullySignaled = true;
		moribund = true; // stops the ring buffer
		system("pause");
		break;

	default:
		printf("An error occurred waiting for the event: %lu\n", GetLastError());
		break;
	}

	// Closes the event
	printf("The Event is closed.\n");
	CloseHandle(hEvent);

	if (successfullySignaled)
	{
		return;
	}
	else
	{
		exit(1);
	}
}