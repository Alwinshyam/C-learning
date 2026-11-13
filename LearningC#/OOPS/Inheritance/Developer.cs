using System;

namespace LearningC_.OOPS.Inheritance
{
    class Developer : Person
    {
        public string ProgrammingLanguage { get; set; }

        public Developer(string name, int age, string language)
            : base(name, age)
        {
            ProgrammingLanguage = language;
        }

        public void WriteCode()
        {
            Console.WriteLine("Developer is writing code...");
        }
    }
}