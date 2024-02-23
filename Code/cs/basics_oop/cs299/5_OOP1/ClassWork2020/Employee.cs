using System;
//using System.Collections;

namespace TestingProject
{
	/// <summary>
	/// A coin with a monetary value.
	/// </summary>
	public class Employee	{
		
		private Employee(string fName, string lName) 
		{
            this.fName = fName;
            this.lName = lName;
            count++;
		}

		public string GetFirstName() 	
		{
			return fName;
		}

		public string GetLastName() 
		{
			return lName;
		}
		
        public static int Count{
            get
            {
                return count;
            }
            set
            {
                count = value;
            }
        }

        public static Employee MakeInstance(string fName, string lName)
        {
            if (count <2)
                return new Employee(fName, lName);
            else
                return null;
        }

		private string fName;
		private string lName;
        private static int count = 0;
	}
}
