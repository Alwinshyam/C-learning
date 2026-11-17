using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    delegate int Operation(int a, int b);

    class Calculator
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static void Calculate(int x, int y, Operation op)
        {
            int result = op(x, y);
            Console.WriteLine(result);
        }

        static void Main()
        {
            Calculate(10, 5, Add);
            Calculate(10, 5, Subtract);
        }
    }

}
