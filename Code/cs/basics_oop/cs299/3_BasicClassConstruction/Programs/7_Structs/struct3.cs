using System;
using System.Runtime.InteropServices;
[StructLayout(LayoutKind.Explicit)]
struct TestUnion
{
    [FieldOffset(0)]
    public int i;
    [FieldOffset(0)]
    public double d;
    [FieldOffset(0)]
    public char c;
    [FieldOffset(0)]
    public byte b1;
}
class Tester
{
    public static void Main()
    {
       TestUnion tu = new TestUnion();
        tu.i = 69;
        Console.WriteLine(tu.i);
        Console.WriteLine(tu.d);
        Console.WriteLine(tu.c);
        Console.WriteLine(tu.b1);
    }
}
