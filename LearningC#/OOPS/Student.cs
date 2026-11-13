namespace LearningC_.OOPS
{
    class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

        public Student(int id, string name)
        {
            this.StudentId = id;
            this.StudentName = name;
        }

        public Student(int id, string name, int age)
            : this(id, name)
        {
            this.Age = age;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"ID: {StudentId}, Name: {StudentName}, Age: {Age}");
        }
    }
}