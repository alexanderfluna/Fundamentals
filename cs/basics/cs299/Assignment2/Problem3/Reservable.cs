// Alexander Luna | Assignment 2 | Problem3
using System;
using System.Timers;

namespace TestingProject
{
    /// <summary>
    /// Define an interface Reservable that inherits from the
    /// Measurable interface, but adds methods void Reserve(double amount)
    /// and void Release (double amount)
    /// </summary>
    public interface Reservable : Measurable
    {
        /// The implementations of Reserve() should ensure that after
        /// their call, GetMeasure() will always return a measure at
        /// least as large as the argument of the Reserve() until
        /// Release() is called. The argument should be non-negative.
        /// @param the amount to be reserved
        void Reserve(double amount);

        /// Release() will reduce the reserved amount with the value
        /// of its arguments. The argument should be non-negative.
        /// @param the amount to be released
        void Release(double amount);
    }
}
