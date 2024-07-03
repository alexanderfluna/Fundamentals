using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    public class InputTester
    {
        public static void Main()  {  
          
          DataSet data = new DataSet();

          bool done = false;
          while (!done)
          {  
             Console.Write("Enter value, Q to quit: ");
             string input = Console.ReadLine(); 
             if (input.ToUpper() == "Q")
                done = true;
             else
             {  
                double x = double.Parse(input);
                data.Add(x);
             }
          }

          Console.WriteLine("Average = " + data.GetAverage());
          Console.WriteLine("Maximum = " + data.GetMaximum());
       }
    }

}
