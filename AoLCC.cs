using System; //I'm using system library to be able to use classes
namespace StudentReport //I'm making container which will organizes code identifiers
{
    class Program 
    {
        static void Main(string[] args) //I started an program by using static void
        {
            Console.WriteLine("Academy of Learning Career College"); //This line is for display an text in console(screen)
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine(); //This line is waiting and reading user answer then coming back as string
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            int pageNum = Convert.ToInt32(Console.ReadLine()); //This line is creating an variable which is gonna be stored as number
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string needHelp = Console.ReadLine();
            bool needHelpBool = bool.Parse(needHelp); //This line is creating an variable which is gonna be stored as true or false
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string positiveExperiences = Console.ReadLine();
            Console.WriteLine("Is there any feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int studyHoursNum = Convert.ToInt32(studyHours);
            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day.");
            Console.ReadLine();

        }
    }
}