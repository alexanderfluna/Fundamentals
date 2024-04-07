#include "SeatReservation.h"
#include "ReservationThread.h"
using namespace System;
using namespace System::Threading;

int main(array<System::String^>^ args)
{
    const int numSeats = 10;
    const int numThreads = 3;

    // Seat reservations array
    SeatReservation^ seatRes = gcnew SeatReservation(numSeats);

    // Array of threads
    array<Thread^>^ threads = gcnew array<Thread^>(numThreads);
    for (int i = 0; i < numThreads; i++)
    {
        String^ threadName = "T" + (i + 1);
        ReservationThread^ thread = gcnew ReservationThread(threadName, seatRes);
        threads[i] = gcnew Thread(gcnew ThreadStart(thread, &ReservationThread::Run));
        threads[i]->Start();
    }

    // Run for a certain period of time
    Thread::Sleep(2000);

    // Instruct threads to stop
    for (int i = 0; i < numThreads; i++)
    {
        threads[i]->Abort();
    }

    // Wait for threads to exit
    for (int i = 0; i < numThreads; i++)
    {
        threads[i]->Join();
    }

    // Print final seat status
    int numAvailable = 0;
    int numReserved = 0;
    seatRes->countSeats(numAvailable, numReserved);
    Console::WriteLine("Seats available: " + numAvailable);
    Console::WriteLine("Seats reserved: " + numReserved);

    return 0;
}