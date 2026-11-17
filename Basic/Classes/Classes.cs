namespace classes
{
    class Classes
    {
        //constructor
        string firstName;
        string lastName;

        public Classes():this("no name provided","no lname provider")
        {

        }
        public Classes(string firstName, string lastName)// constructor 
        {
            this.firstName=firstName;
            this.lastName=lastName;
        }
        public void display()
        {
            Console.WriteLine(firstName+" "+lastName);
        }

        ~Classes() {
            //destructor
        }
    }

}