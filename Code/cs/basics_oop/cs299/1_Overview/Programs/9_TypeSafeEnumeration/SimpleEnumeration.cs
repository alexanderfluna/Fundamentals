using System;

namespace ConsoleApplication1{   

    // declares the enum
    public enum Volume
    {
       Low,
       Medium,
       High
    }

    // demonstrates how to use the enum

    class EnumSwitch
    {
       static void Main()
       {
          // create and initialize instance of enum type
          Volume myVolume = Volume.Medium;
          Console.WriteLine(myVolume);
          // make decision based on enum value
          switch (myVolume)
          {
             case Volume.Low:
                Console.WriteLine("The volume has been turned Down.");
                break;
             case Volume.Medium:
                Console.WriteLine("The volume is in the middle.");
                break;
             case Volume.High:
                Console.WriteLine("The volume has been turned up.");
                break;
          }
          //int n = myVolume; need to cast
          int n = 10;
          myVolume = (Volume)n;
          Console.WriteLine(myVolume);
       }
    }
}
