using System;

class MainClass
{
    public static void Main()
    {
        MyClass mc = new MyClass();

        // Display the contents of mc. 
        foreach (char ch in mc)
            Console.Write(ch + " ");

        Console.WriteLine();

        // Display the contents of mc, again. 
        foreach (char ch in mc)
            Console.Write(ch + " ");

        Console.WriteLine();
    }
}