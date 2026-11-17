using print;
using ProjectA;
using simple=ProjectA.subdiv;//alias
using classes;
using static_instance;
class program 
{
    static void Main(string[] args)
    {
        /*Basic basic = new Basic();
        basic.learning();

        TeamA teamA = new TeamA();
        teamA.display();
        simple.TeamB teamB = new simple.TeamB();
        teamB.display();*/

        Classes classes = new Classes("f","l");
        classes.display();

        Circle circle = new Circle(6);
        float data = circle.display();
        Console.WriteLine(data);



    }
}