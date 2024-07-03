#include "ReservationThread.h"

ReservationThread::ReservationThread(int numSeats)
{
    seats = gcnew array<SeatReservation^>(numSeats);
    for (int i = 0; i < numSeats; i++)
    {
        seats[i] = gcnew SeatReservation();
    }
    this->numSeats = numSeats;
    numReserved = 0;
    numAvailable = numSeats;
}

void ReservationThread::countSeats(int% numAvailable, int% numReserved)
{
    numReserved = 0;
    numAvailable = 0;
    for (int i = 0; i < numSeats; i++)
    {
        if (seats[i]->owner != nullptr)
        {
            numReserved++;
        }
        else
        {
            numAvailable++;
        }
    }
    this->numReserved = numReserved;
    this->numAvailable = numAvailable;
}

bool ReservationThread::ReserveSeat(int seat, String^ owner, int timestamp)
{
    if (seats[seat]->timestamp > timestamp)
    {
        return false; // Someone else reserved the seat after us
    }
    if (seats[seat]->owner == nullptr)
    {
        seats[seat]->owner = owner;
        seats[seat]->timestamp = timestamp;
        return true; // Seat was reserved
    }
    else
    {
        return false; // Seat was already reserved
    }
}

void ReservationThread::ReleaseSeat(int seat, String^ owner)
{
    if (seats[seat]->owner == owner)
    {
        seats[seat]->owner = nullptr;
        seats[seat]->timestamp = 0;
    }
}

void ReservationThread::Run()
{
    Random^ rand = gcnew Random();
    while (true)
    {
        // Count available seats
        int numAvailable = 0;
        int numReserved = 0;
        countSeats(numAvailable, numReserved);

        // Randomly select a seat to reserve
        if (numAvailable > 0)
        {
            int seat = rand->Next(numSeats);
            String^ owner = Thread::CurrentThread->Name;

            // Attempt to reserve the seat
            int timestamp = seats[seat]->timestamp;
            if (ReserveSeat(seat, owner, timestamp))
            {
                // Seat was reserved
                Console::WriteLine("{0} reserved seat {1}", owner, seat);
            }
            else
            {
                // Seat was not reserved
                Console::WriteLine("{0} failed to reserve seat {1}", owner, seat);
            }
        }

        // Sleep for a random amount of time
        Thread::Sleep(rand->Next(1000));
    }
}
