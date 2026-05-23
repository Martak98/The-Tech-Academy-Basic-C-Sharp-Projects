// Import the System namespace
using System;

// Create a namespace for the application
namespace VoidMethodApp
{
    // Main program class
    class Program
    {
        // Main method - entry point of the console application
        static void Main(string[] args)
        {
            // Create an instance of the MathOperations class
            MathOperations math = new MathOperations();

            // First method call using regular arguments. Call the method and pass in two numbers
            math.PerformOperation(10, 25);

            // Display a blank line for readability
            Console.WriteLine();

            // Second method call using named parameters. Call the method again, but specify parameter names
            math.PerformOperation(firstNumber: 7, secondNumber: 50);

            // Pause the console window so the user can view the output
            Console.ReadLine();
        }
    }
}