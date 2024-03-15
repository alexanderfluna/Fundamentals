using System;

namespace ConsoleApplication1
{
    /// <summary
    /// A class to test the Earthquake class.
    /// </summary>
    public class EarthquakeTester   {
        public static void Main()  {  
          Console.Write("Enter a magnitude on the Richter scale: ");
          string temp = Console.ReadLine();
          double magnitude =  double.Parse(temp);
          Earthquake quake = new Earthquake(magnitude);
          Console.WriteLine(quake.GetDescription());
       }
    }
}
