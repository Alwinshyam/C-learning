using System.Diagnostics;

namespace LearningC_
{

    class parent
    {
        public string name { set; get; }

        public parent()
        {
            
        }


        public void display()
        {
            Console.WriteLine(name);
        }
    }
    class child : parent
    {
        public child()
        {

        }
        
    }


    class Program
    {
        static void Main(string[] args)
        {
            child sample = new child();

            parent obj = sample; // Upcasting

            parent obj1 = new child(); // Upcasting

            child sample1 = (child)obj; // Downcasting

        }
    }
}