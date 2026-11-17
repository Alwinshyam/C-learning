using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    delegate void MyDelegate(string name);

    class Program
    {
        static void Welcome(string name)
        {
            Console.WriteLine("Welcome " + name);
        }

        static void Main()
        {
            MyDelegate d = Welcome;
            d("Alwin");
        }
    }
}
