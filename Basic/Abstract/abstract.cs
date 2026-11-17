using System;

namespace abstracts
{

    abstract class Animal
    {
        public abstract void sound();

        public void eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }

    class Dog : Animal
    {
        public override void sound()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class Program
    {
        static void Main()
        {
            Dog d = new Dog();

            d.sound();
            d.eat();
        }
    }
}