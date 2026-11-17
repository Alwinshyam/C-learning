namespace static_instance
{
    class Circle
    {
        static float pi = 3.14f; // static member
        int radius; // instance member

        static Circle() // static constuctor
        {
            Console.WriteLine("this is the statuc costructor");
        }

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public float display()
        {
            return Circle.pi * this.radius * this.radius;
        }
    }
}