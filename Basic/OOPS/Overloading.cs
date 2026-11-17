using System;

class Calc
{
    public void Multiply(int x, int y)
    {
        Console.WriteLine(x * y);
    }
    public void Multiply(int x, int y, int z)
    {
        Console.WriteLine(x * y * z);
    }
    public void Multiply(float x, float y)
    {
        Console.WriteLine(x * y);
    }
}

class main
{
    static void Main()
    {
        Calc cal = new Calc();
        cal.Multiply(4, 5);
        cal.Multiply(2, 3, 10);
        cal.Multiply(2.5f, 4.2f);
    }
}