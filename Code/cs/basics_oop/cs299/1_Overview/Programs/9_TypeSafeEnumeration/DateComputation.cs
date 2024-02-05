using System;

namespace TypeSafeEnumeration {

    public enum Month : int {
        January = 1, February = 2, March = 3, April = 4, May = 5,
        June = 6, July = 7, August = 8, September = 9,
        October = 10, November = 11, December = 12
    }

    public class DateComputation {

		// Fields
		private String [] daysOfWeek = {"Sunday", "Monday", "Tuesday", 
 					"Wednesday", "Thursday", "Friday", "Saturday"}; // Natural indexing

		private int [] startingDayOfMonth = {0, 0, 31, 59, 90, 120, 151, 
               181, 212, 243, 273, 304, 334}; // Natural indexing


		// Indexers (properties)

		// Returns the day corresponding to day of week
		public String this[int index] {
			get { // Read-only indexer
				return daysOfWeek[index - 1];
			}
		}

		// Returns the day within the year
		public int this[Month month, int day, int year] {
			get { // Read-only indexer
				int dayOfYear = startingDayOfMonth[(int) month] + day;
				if (!IsLeapYear(year) || (int) month <= 2) {
					return dayOfYear;
				} else {
					return dayOfYear + 1;
				}
			}
		}

		private bool IsLeapYear(int year) {
			return (year % 4 == 0 && year % 100 != 0) || year % 400 == 0;
		}
	}
}

