using System; //Importing the namespace
namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main(string[] args) //Making entry point 
        {
            Console.WriteLine("Anonymous Income Comparison Program"); //Displaying the text represented by specified objects
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate1 = Console.ReadLine(); //storing a text of specified object
            Console.WriteLine("Hours worked per week?");
            string hours1 = Console.ReadLine();
            int salary1 = Convert.ToInt32(hourlyRate1) * Convert.ToInt32(hours1) * 52; // creating a math with specified numbers
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            string hourlyRate2 = Console.ReadLine();
            Console.WriteLine("Hours worked per week?");
            string hours2 = Console.ReadLine();
            int salary2 = Convert.ToInt32(hourlyRate2) * Convert.ToInt32(hours2) * 52;
            Console.WriteLine("Annual salary of Person 1:");
            Console.WriteLine("salary1");
            Console.WriteLine("Annual salary of Person 2:");
            Console.WriteLine("salary2");
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool isMore = salary1 > salary2; //creating a boolean comperison
            Console.WriteLine(isMore);
            Console.ReadLine(); //reading a specified text 
        }
    }
}