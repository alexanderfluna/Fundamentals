#include "SeatReservation.h"
#include "ReservationThread.h"
using namespace System;
using namespace System::Threading;

int main(array<System::String^>^ args)
{
    int numSeats = 10;
    int numThreads = 3;

    ReservationThread^ system = gcnew ReservationThread(numSeats);

    array<Thread^>^ threads = gcnew array<Thread^>(numThreads);
    for (int i = 0; i < numThreads; i++)
    {
        threads[i] = gcnew Thread(gcnew ThreadStart(system, &ReservationThread::Run));
        threads[i]->Name = "Thread " + (i + 1);
        threads[i]->Start();
    }

    for (int i = 0; i < numThreads; i++)
    {
        threads[i]->Join();
    }

    // Stop the threads
    for (int i = 0; i < numThreads; i++)
    {
        threads[i]->Abort();
    }

    // Print final seat status
    int numAvailable = 0;
    int numReserved = 0;
    system->countSeats(numAvailable, numReserved);
    Console::WriteLine("Seats available: " + numAvailable);
    Console::WriteLine("Seats reserved: " + numReserved);

    return 0;
}
