// Import the System namespace so we can use Console methods
using System;

// Import the namespace where the MathOperations class exists
using MathApp;

// Create the namespace for the application
namespace MathApp
{
    // Main program class
    class Program
    {
        // Main method - entry point of the application
        static void Main(string[] args)
        {
            // Ask the user to enter a number
            Console.WriteLine("Enter a number:");

            // Read the user's input from the console
            string userInput = Console.ReadLine();

            // Convert the string input into an integer
            int number = Convert.ToInt32(userInput);

            // Create an object (instance) of the MathOperations class
            MathOperations math = new MathOperations();

            // Call the AddTen method and store the returned result
            int result1 = math.AddTen(number);

            // Display the result from AddTen
            Console.WriteLine("Number + 10 = " + result1);

            // Call the MultiplyByFive method and store the returned result
            int result2 = math.MultiplyByFive(number);

            // Display the result from MultiplyByFive
            Console.WriteLine("Number * 5 = " + result2);

            // Call the SubtractThree method and store the returned result
            int result3 = math.SubtractThree(number);

            // Display the result from SubtractThree
            Console.WriteLine("Number - 3 = " + result3);

            // Pause the console so the user can see the results
            Console.ReadLine();
        }
    }
}