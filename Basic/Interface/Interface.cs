using System;



interface IName
{
    void display();
}

class Imp : IName
{
    public void display()
    {
        Console.WriteLine("implementation");
    }
}

class main
{
    static void Main()
    {
        IName name=new Imp();
        name.display();
    }
}