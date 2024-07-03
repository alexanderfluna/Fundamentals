// SimpleDlegateDemo.cs - The first program using delegates

using System;

namespace ConsoleApplication1
{
	// 1. Define delegate
    public delegate bool PointFunction(Point p);

	class DelegateDemo
	{
		// 2. Define the actual method
        public static bool IsSuitable(Point p)
        {
            return p.X + p.Y == 0;
        }        

		static void Main()
		{            
            // use the method in Array.Find
            Point [] points = new Point[10];
            for (int i = 0; i < 10; i++){

                points[i] = new Point(i+1, i+1);
            }
            points[5] = new Point(5,-5);
            

            PointFunction Suitable= new PointFunction(IsSuitable);
            int index = Find(points, Suitable);
            Console.WriteLine("A suitable point is at index " + index);
        } // Main

        static int Find(Point [] ps, PointFunction func){
            for (int i = 0; i < ps.Length; i++){
                if (func(ps[i]))
                    return i;
            }
            return -1;
        } // Find 
		
	} // class
} // namespace
