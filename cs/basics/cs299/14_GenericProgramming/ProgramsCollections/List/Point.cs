//Point.cs - Struct Point - used as actual List type parameter.

using System;

public struct Point 
{
	private readonly double x, y;

	public Point(double x, double y)
	{
		this.x = x; this.y = y;
	}

	public double Getx ()
	{
		return x;
	}

	public double Gety ()
	{
		return y;
	}

	public Point Move(double dx, double dy)
	{
		return new Point(x+dx, y+dy);
	}

	public override string ToString()
	{
		return "Point:" + "(" + x + "," + y + ")" + ". ";
	}
}

  