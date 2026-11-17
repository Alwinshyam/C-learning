using System;

class Shape
{
    public virtual void CalculateArea()
    {
        Console.WriteLine("Calculating general shape area");
    }
}

class Circle : Shape
{
    public override void CalculateArea()
    {
        Console.WriteLine("Circle area = 78.5");
    }
}
class main
{
    static void Main()
    {
        Shape circle = new Circle();
        circle.CalculateArea();
    }
}