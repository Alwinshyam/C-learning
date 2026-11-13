using System;

namespace LearningC_.OOPS.Inheritance
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;

            Console.WriteLine("Person constructor called");
        }

        public void DisplayPersonDetails()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }
}