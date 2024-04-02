// Alexander Luna | Assignment 2 | Problem3
using System;
using System.Timers;

namespace TestingProject
{
    public interface Reservable : Measurable
    {
        void Reserve(double amount);

        void Release(double amount);
    }
}