// struct2.cs
using System;

namespace ConsoleApplication1
{
    
    using System;

    class TheClass
    {
        private int x;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                this.x = value;
            }
        }
    }

    struct TheStruct
    {
        private int x;

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                this.x = value;
            }
        }
    }

    class TestClass
    {
        public static void structtaker(TheStruct s)
        {
            s.X = 5; // does not change because it is a copy
                    // if you add ref then it will change it
        }
        public static void classtaker(TheClass c)
        {
            c.X = 5;
        }
        public static void Main()
        {
            TheStruct a = new TheStruct();
            TheClass b = new TheClass();
            a.X = 1;
            b.X = 1;
            structtaker(a);
            classtaker(b);
            Console.WriteLine("a.x = {0}", a.X);
            Console.WriteLine("b.x = {0}", b.X);
        }
    }
}
