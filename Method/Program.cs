// Import the System namespace so we can use Console methods
using System;

// Create a namespace for the application
namespace OptionalParameterApp
{
    // Main program class
    class Program
    {
        // Main method - entry point of the application
        static void Main(string[] args)
        {
            // Create an instance of the MathOperations class
            MathOperations math = new MathOperations();

            // Ask the user to enter the first number
            Console.WriteLine("Enter the first number:");

            // Read the first number from the console
            string firstInput = Console.ReadLine();

            // Convert the first input into an integer
            int firstNumber = Convert.ToInt32(firstInput);

            // Ask the user to enter the second number, let them know it is optional
            Console.WriteLine("Enter the second number (or press Enter to skip):");

            // Read the second input from the console
            string secondInput = Console.ReadLine();

            // Check whether the user entered anything
            if (string.IsNullOrWhiteSpace(secondInput))
            {
                // If the user did not enter a second number, call the method using only the first parameter
                int result = math.AddNumbers(firstNumber);

                // Display the result to the screen
                Console.WriteLine("Result: " + result);
            }
            else
            {
                // Convert the second input into an integer
                int secondNumber = Convert.ToInt32(secondInput);

                // Call the method using both parameters
                int result = math.AddNumbers(firstNumber, secondNumber);

                // Display the result to the screen
                Console.WriteLine("Result: " + result);
            }

            // Pause the console window so the user can see the output
            Console.ReadLine();
        }
    }
}