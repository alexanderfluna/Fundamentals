#include "SeatReservation.h"

SeatReservation::SeatReservation(int numSeats)
{
    seats = gcnew array<String^>(numSeats);
    lockObj = gcnew Object();
}

bool SeatReservation::ReserveSeat(int seatNum, String^ threadName)
{
    Monitor::Enter(lockObj);
    bool success = false;

    try
    {
        if (seats[seatNum] == nullptr)
        {
            seats[seatNum] = threadName;
            success = true;
        }
    }
    finally
    {
        Monitor::Exit(lockObj);
    }

    return success;
}

void SeatReservation::ReleaseSeat(int seatNum)
{
    Monitor::Enter(lockObj);

    try
    {
        seats[seatNum] = nullptr;
    }
    finally
    {
        Monitor::Exit(lockObj);
    }
}

void SeatReservation::countSeats(int% numAvailable, int% numReserved)
{
    Monitor::Enter(lockObj);

    try
    {
        numAvailable = 0;
        numReserved = 0;

        for (int i = 0; i < seats->Length; i++)
        {
            if (seats[i] == nullptr)
            {
                numAvailable++;
            }
            else
            {
                numReserved++;
            }
        }
    }
    finally
    {
        Monitor::Exit(lockObj);
    }
}
