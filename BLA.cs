using System;
namespace BooleanLogic //organizing system for a program by giving it namespace
{
    class Program //defining the structure of objects
    {
        static void Main(string[] args) //creating an entry point for a program
        {
            Console.WriteLine("Car Insurance Application"); //writing a specified text
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());  //converting the value of specified 32-bit integer
            Console.WriteLine("Have you everhad DUI? (Yes or No)");
            string answer = Console.ReadLine().ToLower(); //returns an answer to lowercase
            bool dui = answer == "yes"; //using boolean logic 
            Console.WriteLine("How many speeding tickets do you have?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified for insurance?");
            bool qualified = (age > 15) && !dui && (tickets <= 3);
            Console.WriteLine(qualified);
        }
    }
}