using System;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace TestingProject
{
    public class EmployeeTest
    {
        public static void Main()
        {
            //Employee emp1 = new Employee("Peter", "Thomas");
            Employee emp1 = Employee.MakeInstance("Peter", "Thomas");
            Console.WriteLine(Employee.Count);
            //Employee emp2 = new Employee("Mary", "Thomas");
            Employee emp2 = Employee.MakeInstance("Mary", "Thomas");
            Console.WriteLine(Employee.Count);
            Employee emp3 = Employee.MakeInstance("Mary", "Thomas");
            Console.WriteLine(Employee.Count);

        }
    }
}