// Import the System namespace for console functionality
using System;

// Create a namespace for the application
namespace OverloadedMethodsApp
{
    // Main program class
    class Program
    {
        // Main method - the entry point of the console application
        static void Main(string[] args)
        {
            // Create an instance of the MathOperations class
            MathOperations math = new MathOperations();

            // Call the first overloaded method

            // Create an integer value to pass into the method
            int intNumber = 10;

            // Call the DoMath method that accepts an integer
            int intResult = math.DoMath(intNumber);

            // Display the result to the console
            Console.WriteLine("Integer method result: " + intResult);

            // Call the second overloaded method

            // Create a decimal value to pass into the method
            decimal decimalNumber = 12.5m;

            // Call the DoMath method that accepts a decimal
            int decimalResult = math.DoMath(decimalNumber);

            // Display the result to the console
            Console.WriteLine("Decimal method result: " + decimalResult);

            // Call the third overloaded method

            // Create a string value that can be converted into an integer
            string stringNumber = "30";

            // Call the DoMath method that accepts a string
            int stringResult = math.DoMath(stringNumber);

            // Display the result to the console
            Console.WriteLine("String method result: " + stringResult);

            // Pause the console window so the user can see the output
            Console.ReadLine();
        }
    }
}