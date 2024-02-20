#region Using directives

using System;
using System.Text;

#endregion

namespace AbstractProperties {

    public class AbstractPropertyTester {
        static void Main(string[] args) {
			Square square = new Square(4);
			System.Console.WriteLine("The area of the square is " + square.Area);

        }
    }
}
