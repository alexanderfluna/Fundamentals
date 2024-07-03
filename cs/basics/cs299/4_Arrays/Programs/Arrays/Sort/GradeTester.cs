using System;
using System.Collections;

namespace SortingGrades {
	class GradeTester{
		static void Main(){
            String[,] grades = {
				{"Smith Robert", "60", "70", "80", "90"},
				{"Abbot John",   "70", "80", "90", "100"},
				{"Markus Susan", "99", "98", "97", "96"},
				{"Cull Megan", "20", "40", "60", "80"},
				{"Simmons Frank", "0", "20", "40", "60"},
				{"Edwards Ryan", "30", "20", "10", "0"}
			};

            StudentGrades app = new StudentGrades(grades, 6, 5);
            Console.WriteLine("Original array");
            app.DisplayGrades();

            // key column 0, ascending order, type string
            app.SortGrades(0, true, true);
            Console.WriteLine("Array sorted by column 0, ascending order, column 0 is type string");
            app.DisplayGrades();

            // key column 1, descending order, type not string
            app.SortGrades(1, false, false);
            Console.WriteLine("Array sorted by column 1, descending order, column 1 is type double");
            app.DisplayGrades();

            // key column 3, ascending order, type not string
            app.SortGrades(3, true, false);
            Console.WriteLine("Array sorted by column 3, ascending order, column 3 is type double");
            app.DisplayGrades();

            System.Console.ReadLine();
        }
    }
}
/* Output
Smith Robert            60              70              80              90
Abbot John              70              80              90              100
Markus Susan            99              98              97              96
Cull Megan              20              40              60              80
Simmons Frank           0               20              40              60
Edwards Ryan            30              20              10              0
--------------------------------------


Abbot John              70              80              90              100
Cull Megan              20              40              60              80
Edwards Ryan            30              20              10              0
Markus Susan            99              98              97              96
Simmons Frank           0               20              40              60
Smith Robert            60              70              80              90
--------------------------------------


Markus Susan            99              98              97              96
Abbot John              70              80              90              100
Smith Robert            60              70              80              90
Edwards Ryan            30              20              10              0
Cull Megan              20              40              60              80
Simmons Frank           0               20              40              60
--------------------------------------


Edwards Ryan            30              20              10              0
Simmons Frank           0               20              40              60
Cull Megan              20              40              60              80
Smith Robert            60              70              80              90
Abbot John              70              80              90              100
Markus Susan            99              98              97              96
--------------------------------------
*/
