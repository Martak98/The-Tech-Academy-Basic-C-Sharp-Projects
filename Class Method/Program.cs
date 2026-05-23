// Import the System namespace
using System;

// Create a namespace for the application
namespace StaticClassApp
{
    // Main program class
    class Program
    {
        // Main method - entry point of the console application
        static void Main(string[] args)
        {
            // Ask the user to enter a whole number
            Console.WriteLine("Enter a whole number:");

            // Read the user's input from the console
            string userInput = Console.ReadLine();

            // Convert the user's input into an integer
            int number = Convert.ToInt32(userInput);

            // Create a variable to store the output result
            int dividedResult;

            // Call the DivideByTwo method from the static class
            MathHelper.DivideByTwo(number, out dividedResult);

            // Display the result to the screen
            Console.WriteLine("Your number divided by 2 is: " + dividedResult);

            
            // Example of calling the overloaded method
            // Create a decimal number for demonstration
            decimal decimalNumber = 15.5m;

            // Create a variable to store the decimal result
            decimal decimalResult;

            // Call the overloaded version of DivideByTwo
            MathHelper.DivideByTwo(decimalNumber, out decimalResult);

            // Display the decimal result to the screen
            Console.WriteLine("15.5 divided by 2 is: " + decimalResult);

            // Pause the console window so the user can see the output
            Console.ReadLine();
        }
    }
}