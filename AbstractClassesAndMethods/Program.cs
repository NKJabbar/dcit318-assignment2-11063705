using System;

abstract class Shape
{
    public abstract double GetArea();
}

class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

class Rectangle : Shape
{
    private double width;
    private double height;

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public override double GetArea()
    {
        return width * height;
    }
}

class Program
{
    static void Main()
    {
        Shape circle = new Circle(7);
        Shape rectangle = new Rectangle(6, 8);

        Console.WriteLine($"Circle area: {circle.GetArea():F3}");
        Console.WriteLine($"Rectangle area: {rectangle.GetArea():F3}");
    }
}
