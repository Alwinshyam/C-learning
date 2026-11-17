using System;

namespace print
{
    class Basic()
    {
        public void learning()
        {
            // print statement in here from the System namespace console function is coming
            Console.WriteLine("this is the way to print");
            int a = 1;
            int b = 2;
            Console.WriteLine("{0}+{1}", a, b);
            Console.WriteLine($"{a}{b}");
            Console.WriteLine(@"\n this special function won't work in here");

            // Operators

            // assignment operator
            int c = 0;

            // arithmetic operator
            c = a + b;
            Console.WriteLine(c);
            c = a - b;
            Console.WriteLine(c);
            c = a * b;
            Console.WriteLine(c);
            c = a / b;
            Console.WriteLine(c);
            c = a % b;
            Console.WriteLine(c);

            // comparison operator
            bool d = false;
            d = a == b;
            Console.WriteLine(d);
            d = a != b;
            Console.WriteLine(d);
            d = a > b;
            Console.WriteLine(d);
            d = a < b;
            Console.WriteLine(d);
            d = a >= b;
            Console.WriteLine(d);
            d = a <= b;
            Console.WriteLine(d);

            // conditional operators
            d = a > b && b > a;
            Console.WriteLine(d);
            d = (a > b) || a > b;
            Console.WriteLine(d);

            // Ternary Operator
            Console.WriteLine(a > b ? "a is greater" : "a is less");

            // null-coalescing operator
            // In C#, normally we can't declare null in a value type, so we use ? to allow it.
            int? e = null;
            // int f = null; this is not allowed, so we use ? in the declaration.
            // If I want to typecast, I have to go with the explicit one only.

            e = 2;
            int data = e ?? 0;
            Console.WriteLine(data);

            // converting string numbers into numbers methods
            string s = "10";
            int num = Convert.ToInt32(s);
            int num1 = int.Parse(s);
            int num3;
            bool num2 = int.TryParse(s, out num3);
            Console.WriteLine(num);
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);

            // Arrays

            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            Console.WriteLine(arr[0]);

            // if else if else
            int age = 18;
            if (age < 18)
            {
                Console.WriteLine("teen");
            }
            else if (age > 18 || age < 30)
            {
                Console.WriteLine("man");
            }
            else
            {
                Console.WriteLine("aged man");
            }

            // Switch

            String color = Console.ReadLine();  // this is the way to get an input; the return type is string
            switch (color)
            {
                case "red":
                    Console.WriteLine("Color is Red");
                    break;

                case "blue":
                    Console.WriteLine("Color is Blue");
                    break;

                case "green":
                    Console.WriteLine("Color is Green");
                    break;

                default:
                    Console.WriteLine("Unknown Color");
                    break;
            }

            // do while loop

            int loop = 5;

            do
            {
                loop++;
                Console.WriteLine(loop);
            } while (loop <= 5);

            // while

            int loops = 5;
            while (loops <= 7)
            {
                Console.WriteLine(loops);
                loops++;
            }

            // for loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            // foreach
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

            // XML comments

            Demo demo = new Demo();
            demo.display();

            // min and max
            int min = int.MinValue; int max = int.MaxValue;
            Console.WriteLine(min + "" + max);

        }
    }

    /// <summary>
    /// just for practice
    /// </summary>
    class Demo
    {

        //Method without return type and parameter
        public void display()
        {
            Console.WriteLine("XML comments");
        }
        //Method without return type and with parameter
        public void display1(int data)
        {
            Console.WriteLine("XML comments" + data);
        }
        //Method  return type and parameter
        public int display2(int data)
        {
            return data;
        }
    }
}