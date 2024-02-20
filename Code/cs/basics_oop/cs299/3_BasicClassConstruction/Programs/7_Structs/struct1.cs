using System;

namespace ConsoleApplication1
{
    struct SimpleStruct
    {
        // instance variable
        private int xval;

        //property
        public int X
        {
            get
            {
                return xval;
            }
            set
            {
                if (value < 100)
                    xval = value;
            }
        }

        //method
        public void DisplayX()
        {
            Console.WriteLine("The stored value is: {0}", xval);
        }
    }

    class TestClass
    {
        public static void Main()
        {
            SimpleStruct ss = new SimpleStruct();
            ss.X = 5;
            ss.DisplayX();
        }
    }


    
    
    
    
}
