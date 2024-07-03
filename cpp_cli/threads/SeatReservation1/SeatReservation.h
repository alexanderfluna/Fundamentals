#pragma once
using namespace System;
using namespace System::Threading;

ref class SeatReservation
{
public:
    array<String^>^ seats;
    Object^ lockObj;

    SeatReservation(int numSeats);

    bool ReserveSeat(int seatNum, String^ threadName);

    void ReleaseSeat(int seatNum);

    void countSeats(int% numAvailable, int% numReserved);
};
