using System;

namespace interfaceofexplicity
{


    interface IEng
    {
        void display();
    }

    interface ITam
    {
        void display();
    }

    class Imp : IEng, ITam
    {
        void IEng.display()
        {
            Console.WriteLine("English");
        }

        void ITam.display()
        {
            Console.WriteLine("Tamil");
        }
    }

    class MainClass
    {
        static void Main()
        {
            IEng name1 = new Imp();
            ITam name2 = new Imp();

            name1.display();
            name2.display();
        }
    }
}