#pragma once
#include "SeatReservation.h"
using namespace System;
using namespace System::Threading;

ref class ReservationThread
{
private:
    String^ name;
    SeatReservation^ seatRes;
    Random^ rand;

public:
    ReservationThread(String^ threadName, SeatReservation^ seatReservation);

    void Run();
};
