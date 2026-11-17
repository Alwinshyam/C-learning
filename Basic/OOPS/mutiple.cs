using System;



interface IWalk
{
    void Walk();
}
interface IRun
{
    void Run();
}
class Imp : IWalk, IRun
{
    public void Walk()
    {
        Console.WriteLine("i can walk");
    }
    public void Run()
    {
        Console.WriteLine("i can run");
    }
}

class main
{
    static void Main()
    {
        Imp name = new Imp();
        name.Walk();
        name.Run();

    }
}