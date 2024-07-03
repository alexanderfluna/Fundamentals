#pragma once
#include "SeatReservation.h"
using namespace System;
using namespace System::Threading;
ref class ReservationThread
{
private:
    array<SeatReservation^>^ seats;
    int numSeats;
    int numReserved;
    int numAvailable;

public:
    ReservationThread(int numSeats);

    void countSeats(int% numAvailable, int% numReserved);

    bool ReserveSeat(int seat, String^ owner, int timestamp);

    void ReleaseSeat(int seat, String^ owner);

    void Run();
};
