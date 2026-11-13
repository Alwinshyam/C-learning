using System;

namespace LearningC_.OOPS.Inheritance
{
    class Manager : Person
    {
        public int TeamSize { get; set; }

        public Manager(string name, int age, int teamSize)
            : base(name, age)
        {
            TeamSize = teamSize;
        }

        public void ManageTeam()
        {
            Console.WriteLine("Manager is managing the team...");
        }
    }
}