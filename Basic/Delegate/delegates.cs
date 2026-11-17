using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    using System;
    delegate void bye();
    class Mydelegates

    {
        public void bye()
        {
            Console.WriteLine("good bye");
        }
    }

    class Call
    {
        static void Main()
        {
            Mydelegates del = new Mydelegates();

            bye call = del.bye;
            call();
        }
    }
}
