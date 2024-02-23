using System;

namespace OtherModifiers
{

    public sealed class Modifiers
    {

        // Command
        public void ProduceSomeValue(out int someValue)
        {
            // Console.WriteLine(someValue); must assign before use
            someValue = 17;
        }

        public void ChangeSomeValue(ref int someValue)
        {
            someValue *= 5;
        }
    }

    // cannot derive from a sealed class
    // public class Subclass : Modifiers { }
}


