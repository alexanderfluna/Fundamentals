#include "ReservationThread.h"

ReservationThread::ReservationThread(String^ threadName, SeatReservation^ seatReservation)
{
    name = threadName;
    seatRes = seatReservation;
    rand = gcnew Random();
}

void ReservationThread::Run()
{
    Console::WriteLine(name + " started");

    while (true)
    {
        // Release current seat
        for (int i = 0; i < seatRes->seats->Length; i++)
        {
            if (seatRes->seats[i] == name)
            {
                seatRes->ReleaseSeat(i);
                break;
            }
        }

        // Select new seat
        int numAvailable = 0;
        int numReserved = 0;
        seatRes->countSeats(numAvailable, numReserved);

        if (numAvailable == 0)
        {
            // No available seats, wait and try again
            Thread::Sleep(rand->Next(1000));
        }
        else
        {
            int seatNum = rand->Next(seatRes->seats->Length);

            while (seatRes->seats[seatNum] != nullptr)
            {
                seatNum = rand->Next(seatRes->seats->Length);
            }

            if (seatRes->ReserveSeat(seatNum, name))
            {
                // Seat reserved
                Console::WriteLine(name + " reserved seat " + seatNum);
                Thread::Sleep(rand->Next(100));
            }
            else
            {
                // Seat taken, wait and try again
                Thread::Sleep(rand->Next(1000));
            }
        }
    }
}
