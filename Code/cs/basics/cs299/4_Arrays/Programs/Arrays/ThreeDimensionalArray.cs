/* CalorieCounter.cs      Author:  Doyle
 * Demonstrates multi-dimensional array
 * through a calorie counter program.
 * Initializes array with values.
 * Accumulates calories per day and
 * displays report by day.
 */
using System;
namespace CalorieCounter
{
	class CalorieCounter
	{
        static void Main( )
        {
            int [, ,] calories = {{{900, 750, 1020, 0},
                                {300, 1000, 2700, 0},
                                {500, 700, 2100, 0},
                                {400, 900, 1780, 0},
                                {600, 1200, 1100, 0},
                                {575, 1150, 1900, 0},
                                {600, 1020, 1700, 0}},
                                 
                               {{890, 1900, 785, 0},
                                {450, 1000, 2005, 0},
                                {400, 1200, 2100, 0},
                                {400, 900, 1780, 0},
                                {600, 1200, 1500, 0},
                                {500, 750, 1900, 0},
                                {600, 890, 1200, 0}},
                                
                               {{850, 750, 1350, 0},
                                {300, 1000, 2330, 0},
                                {350, 800, 2100, 0},
                                {400, 900, 1080, 0},
                                {600, 1250, 1100, 0},
                                {575, 1000, 2140, 0},
                                {600, 870, 1600, 0}},

                               {{500, 1500, 1020, 0},
                                {400, 1100, 2700, 0},
                                {170, 700, 2100, 0},
                                {400, 1240, 1780, 0},
                                {600, 1100, 1100, 0},
                                {575, 1150, 1750, 0},
                                {575, 1500, 2100, 0}}};
            AccumulateCalories(calories);
            DisplayTotals(calories);
         }

        public static void AccumulateCalories(int [, , ] calories)
        {
            
            for (int wk = 0; wk < calories.GetLength(0); wk++)
                for (int da = 0; da < calories.GetLength(1); da++)
                    for (int ml = 0; ml < calories. GetLength(2) - 1; ml++)
                        calories [wk, da, 3] += calories [wk, da, ml];
 
        }

        public static void DisplayTotals(int [, , ] calories)
        {
            string [ ] dayName = {"Sun", "Mon", "Tue",
                                  "Wed", "Thr", "Fri",
                                  "Sat"}; 

            Console.WriteLine("Week#\tDay#\tTotalCalories");
            for (int wk = 0; wk < calories.GetLength(0); wk++)
                for (int da = 0; da < calories.GetLength(1); da++)
                     Console.WriteLine("{0}\t{1}\t{2}", wk + 1, 
                                       dayName[da], calories [wk,  da, 3]); 
        }
	}
}
