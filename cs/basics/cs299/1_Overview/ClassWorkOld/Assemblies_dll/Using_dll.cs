using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Csharp_ConsoleProject
{
    class Program
    {
        static void Main(string[] args)
        {

            ClassLibrary1Project.CharacterCasing test 
                = new ClassLibrary1Project.CharacterCasing();
            Console.WriteLine(test.LowerCase("HELLO"));

            
        }
    }
}
