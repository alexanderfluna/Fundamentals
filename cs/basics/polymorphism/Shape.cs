using System;

// Base class
class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

// Derived class overriding the Draw method
class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

// Derived class overriding the Draw method
class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a square");
    }
}

class Program
{
    static void Main()
    {
        // Creating objects of different types
        Shape genericShape = new Shape();
        Circle circle = new Circle();
        Square square = new Square();

        // Using polymorphism to call the Draw method
        DrawShape(genericShape);
        DrawShape(circle);
        DrawShape(square);
    }

    // A method that accepts objects of the base class and calls the Draw method
    static void DrawShape(Shape shape)
    {
        shape.Draw();
    }
}
