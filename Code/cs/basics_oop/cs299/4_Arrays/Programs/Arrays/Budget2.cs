using System;

namespace ConsoleApplication1
{

	/// <summary>
	/// uses two-dimensional budget array
	/// budget categories are fixed
	/// Exercise: Change this program to use the standard C# output formatting
	/// </summary>
 
   
    class  Budget2 
	{
        
        
        static double  R2(double  x) {
            // rounds a double value to two decimal places
            double  z=((double )(Math.Round (x*100)))/100;
            return  z;
        } 
        
        public static void Main() {

            int  maxrow=4;
            int  maxcol=5;  

            // initialize the data:
            double[,]  spend = new double[,] {
                /*row 0: ignore*/      {0, 0, 0, 0, 0, 0},
                /*row 1:January:*/     {0,12,15,80,40,30},
                /*row 2:February:*/    {0,34,20,76,11,28},
                /*row 3:March:*/       {0,21,15,56,80,20},
                /*row 4:April:*/       {0,38,59,94,17,24}
            };

            double [] coltotal= new double[] {0,0,0,0,0,0}; // to hold column totals

            string[]  month = new string[] {" ","January ",
                                                "February",
                                                "March   ",
                                                "April   "};
            string[] categ = new string[] {"         ",
                                           "Books    ",
                                           "Clothes  ",
                                           "Food     ",
                                           "Travel   ",
                                           "Entertainment  "};

            // display the labels at the top of each column:
            for  (int  col=0; col<=maxcol; col++)
                Console.Write (categ[col]);

            Console.WriteLine(" Total");


            // these two nested loops display the values and
            // calculate the row and column totals
            for  (int  row=1; row<=maxrow; row++) {
                double  rowtot=0; 
                Console.Write(month[row]);
                for  (int  col=1; col<=maxcol; col++) {
                    Console.Write("  " + R2(spend[row, col]) + "     ");
                    rowtot+=spend[row,col];
                    coltotal[col]+=spend[row,col];
                } // end for col
                Console.WriteLine ("         "+R2(rowtot));
            } //end for row 

            // display the column totals below each column:
            Console.Write ("Total:  ");
            double  grandtotal=0;
            for  (int  col=1; col<=maxcol; col++) {
                Console.Write (" "+coltotal[col] + "     ");
                grandtotal+=coltotal[col];
            }
           
            Console.WriteLine ("         "+R2(grandtotal));

        } // Main
    } // class

}// namespace
