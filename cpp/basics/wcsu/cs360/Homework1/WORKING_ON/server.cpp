// Alexander Luna | Problem 1

#define _CRT_SECURE_NO_WARNINGS
#include <windows.h>
#include <stdio.h>
#include <random>
#include <vector>
#include <unordered_map>
#include <iostream>
#include <map>
#include <regex>
#include <thread>

int generateRandomNumber();
void createMailSlot();
void createRingBuffer();
void createEvent();

// Maps player's name to player's id
std::unordered_map<std::string, std::string> players;

// The secret number the clients will try to guess
int secretNumber;

// Define the constants determining the shared memory parameters
// This is the size of the shared memory buffer
constexpr auto SHARED_MEMORY_SIZE = 100;

// Store the player id of the winning player
char playerId;

// This is a memory overlay defining the structure of the buffer
typedef struct
{
	unsigned char  capacity;
	unsigned char  tail;
	unsigned char  head;
	unsigned char  buffer;
} CircularBuffer;

int main()
{
	printf("This mutiplayer guessing game consists of a Server and some number of Clients."
			"\nThe Server will generate a random number between 0 - 255 and the Clients"
			"\nhave to guess this number. If you can guess the number, you win!\n\n");

	// Generates secret number between 0-255
	secretNumber = generateRandomNumber();
	printf("The secret number is: %i.\n", secretNumber);

	// Creates thread to keep mailslot open
	std::thread mailSlotThread(createMailSlot);

	// Creates ring buffer to receive guesses
	createRingBuffer();

	// Creates event to signal to clients to stop guessing
	createEvent();

	// Waits for last mailslot message to be sent
	mailSlotThread.join();

	printf("\nThank you for playing!\n");
	for (const auto& pair : players) {
		std::cout << "Player: " << pair.first << "\tID: " << pair.second << std::endl;
	}

	return 0;
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

// Creates the MailSlot to open communicate between the client and server
void createMailSlot()
{
	// Define our Mailslot
	LPCWSTR szMailslot = L"\\\\.\\mailslot\\ExampleMailslot";

	// Define a buffer for holding messages
	constexpr auto BUFFER_LENGTH = 1024;
	char readBuffer[BUFFER_LENGTH] = { 0 };
	DWORD bytesRead;

	// Create the Mailslot
	HANDLE hMailslot = CreateMailslotW(
		szMailslot,		          // The name of our Mailslot
		BUFFER_LENGTH,            // The size of the input buffer
		MAILSLOT_WAIT_FOREVER,    // Wait forever for new mail
		NULL					  // Use the default security attributes
	);

	if (hMailslot == INVALID_HANDLE_VALUE)
	{
		printf("There was error creating the Mailslot: %lu\n", GetLastError());
		exit(1);
	}

	// Create a map of sequences
	std::map<int, bool> sequences;
	std::regex sequenceRegex("(.*)sequence\\s+([0-9]+)\\s+(.*)");
	std::smatch match;

	// Wait for a message
	while (true)
	{
		bool bResult = ReadFile(hMailslot, readBuffer, BUFFER_LENGTH, &bytesRead, NULL);  // No overlapping I/O
		if (!bResult || (bytesRead <= 0))
		{
			printf("An error occurred reading the message: %lu\n", GetLastError());
			CloseHandle(hMailslot);
			exit(1);
		}

		if (strcmp(readBuffer, "quit") == 0)
		{
			printf("Received quit message. Closing mailslot.\n");
			CloseHandle(hMailslot);
			break;
		}

		// Get the sequence number from readBuffer
		std::string rawMessage(readBuffer);
		if (std::regex_search(rawMessage, match, sequenceRegex))
		{
			// Get the embedded sequence number
			int sequenceNumber = atoi(match[2].str().c_str());

			// Check if this sequence number has already been seen
			auto search = sequences.find(sequenceNumber);
			if (search == sequences.end())
			{
				// The sequence number had not been seen previously.
				// Add the sequence number to the set of already seen numbers.
				//sequences[sequenceNumber] = true;
				
				printf("Player: %s| ID: %s has joined. Press any key in client to begin.\n", match[1].str().c_str(), match[3].str().c_str());
				
				// Stores player's name and player's id in map
				players[match[1]] = match[3].str();
			}
		}
	}
	CloseHandle(hMailslot);
}

// Creates ring buffer to read guesses from the client
void createRingBuffer()
{
	// Create the semaphore we will use to control access to the circular buffer.
	HANDLE hSemaphore = CreateSemaphore(
		nullptr,							// Use the default security attributes
		1,								// Initial 'count'
		1,								// Maximum 'count'
		TEXT("SharedMemorySemaphore")	// The name of the semaphore
	);

	// Exit if there was an error creating the semaphore
	if (hSemaphore == INVALID_HANDLE_VALUE)
	{
		printf("An error occurred creating the semaphore: %lu\n", GetLastError());
		exit(1);
	}

	// Create the Shared Memory object
	HANDLE hMemory = CreateFileMapping(
		INVALID_HANDLE_VALUE,			// We will use the page file for backing
		nullptr,							// Use the default security attributes
		PAGE_READWRITE,					// We need both read and write access
		0,								// Maximum Object size, use default
		SHARED_MEMORY_SIZE,				// Size of the shared memory
		TEXT("ShareMemoryBuffer")		// Name of our shared memory buffer
	);

	// Exit if there was an error creating the Shared Memory object
	if (hMemory == INVALID_HANDLE_VALUE || hMemory == nullptr)
	{
		printf("An error occurred created the shared memory buffer:%lu\n", GetLastError());
		CloseHandle(hSemaphore);
		exit(1);
	}

	// Create the memory mapping, ...
	auto pBuffer = (unsigned char*)MapViewOfFile(hMemory, FILE_MAP_ALL_ACCESS, 0, 0, SHARED_MEMORY_SIZE);
	if (!pBuffer)
	{
		printf("An error occurred mapping the shared memory: %lu\n", GetLastError());
		CloseHandle(hSemaphore);
		CloseHandle(hMemory);
	}

	// ... overlay the Circular Buffer structure and ...
	auto pCircularBuffer = (CircularBuffer*)pBuffer;

	// ... set up its structure
	pCircularBuffer->capacity = SHARED_MEMORY_SIZE - 3;
	pCircularBuffer->tail = 0;
	pCircularBuffer->head = 0;

	// Will be set to true when the client guesses the correct number
	volatile bool moribund = false;

	// This is the index of the 'next' item in the circular buffer to be filled
	// We'll use it to determine when the buffer is full.
	int next;

	// This is value just read from the buffer.
	int guess;

	printf("All set and ready for guesses. New players can join at any time.\n");
	// Loop until the correct guess is received.
	while (!moribund)
	{
		// First get the semaphore.
		// Wait for up to 100 milliseconds
		DWORD dwWaitResult = WaitForSingleObject(hSemaphore, 100);

		// Check if the semaphore was signalled.
		switch (dwWaitResult)
		{
			// Check if the semaphore was signalled
		case WAIT_OBJECT_0:
			// Check if there is anything of interest in the buffer
			if (pCircularBuffer->tail != pCircularBuffer->head)
			{
				next = (pCircularBuffer->tail + 1) % pCircularBuffer->capacity;
				guess = (&pCircularBuffer->buffer)[pCircularBuffer->tail];

				// Update the tail;
				pCircularBuffer->tail = next;
				printf("Received guess: %d\n", guess);
				if (guess == secretNumber)
				{
					moribund = true;
					playerId = (&pCircularBuffer->buffer)[pCircularBuffer->tail];
					std::cout << "The winner's player id: " << (&pCircularBuffer->buffer)[pCircularBuffer->tail] << std::endl;
				}
			}
			else
			{
				// Nothing available. Buffer is empty.
			}

			// Release the semaphore so another process may use it.
			if (!ReleaseSemaphore(hSemaphore, 1, nullptr))
			{
				printf("Failed to release semaphore!: %lu\n", GetLastError());
			}
			break;

			// Check if the semaphore was not signalled. This is not a problem on the sink end.
		case WAIT_TIMEOUT:
		default:
			break;

		}
	}

	// Closes the semaphore and Shared Memory object
	printf("\nThe correct guess has been received! \nClosing Ring Buffer.\n");
	CloseHandle(hSemaphore);
	CloseHandle(hMemory);
}

// Creates event to signal to the clients to stop sending guesses
void createEvent()
{
	// Set up security descriptor with a null access control list.
	// This will allow any other process to access this event.
	auto pSD
		= (PSECURITY_DESCRIPTOR)LocalAlloc(LPTR, SECURITY_DESCRIPTOR_MIN_LENGTH);
	InitializeSecurityDescriptor(pSD, SECURITY_DESCRIPTOR_REVISION);
	SetSecurityDescriptorDacl(pSD, // Our security descriptor
		TRUE,                      // Is the ACL present?
		NULL,                      // The ACL, null in this case
		FALSE);                    // The ACL is set by hand.

	// Now set up a security attributes structure and ...
	SECURITY_ATTRIBUTES sa = { 0 };
	sa.nLength = sizeof(sa);

	// ... set it up to use security descriptor.
	sa.lpSecurityDescriptor = pSD;
	sa.bInheritHandle = FALSE;

	// Create our event. We create it as a manual reset event.
	// An auto reset event is unsignaled after the first process
	// waiting for it processes it.
	HANDLE hEvent = CreateEvent(
		&sa,	// Use our security attributes structure
		true,	// Manual-reset mode
		false,	// Initially unsignaled
		TEXT("SampleEvent")
	);
	if (hEvent == INVALID_HANDLE_VALUE)
	{
		printf("Creating the event failed!: %lu\n", GetLastError());
		exit(1);
	}

	// Wait for the user to press a key
	printf("Press Enter to send the Event.\n");
	getchar();

	// Signal the event
	if (!SetEvent(hEvent))
	{
		printf("There was an error signaling the Event: %lu\n", GetLastError());
		exit(1);
	}

	// Closes the event
	printf("The Event is closed.\n");
	CloseHandle(hEvent);
}