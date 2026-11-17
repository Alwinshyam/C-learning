using System;

class Person
{
    public string name;
    public Person(string name)
    {
        this.name = name;
    }
    public void display()
    {
        Console.WriteLine("Name =" + name);
    }
}

class Employee : Person
{

    int salary;
    public Employee(int salary, string name) : base(name)
    {
        this.salary = salary;
    }
    public void display()
    {
        Console.WriteLine("Name =" + name);
        Console.WriteLine("salary =" + salary);
    }
}

class main
{
    static void Main()
    {
        Employee emp = new Employee(20000, "alwin");
        emp.display();

    }
}