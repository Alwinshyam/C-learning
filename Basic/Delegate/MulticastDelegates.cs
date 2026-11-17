using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates
{
    using System;

    delegate void MyDelegate();

    class Program
    {
        static void Method1()
        {
            Console.WriteLine("Method 1");
        }

        static void Method2()
        {
            Console.WriteLine("Method 2");
        }

        static void Method3()
        {
            Console.WriteLine("Method 3");
        }

        static void Main()
        {
            MyDelegate d = Method1;

            d += Method2;
            d += Method3;

            d();
        }
    }
}
