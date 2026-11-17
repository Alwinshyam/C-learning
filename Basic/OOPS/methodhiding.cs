using System;

class Animal
{
    public void sound()
    {
        Console.WriteLine("Animal makes sound");
    }
}
class Dog : Animal
{
    public new void sound()
    {
        Console.WriteLine("Dog barks");
    }
}

class main
{
    static void Main(string[] args)
    {
        Animal obj1 = new Dog();
        obj1.sound();
        Dog obj2 = new Dog();
        obj2.sound();
    }
}