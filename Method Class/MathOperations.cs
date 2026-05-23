// Import the System namespace so we can use Console methods
using System;

// Create a namespace for the application
namespace VoidMethodApp
{
    // Create a class called MathOperations
    public class MathOperations
    {
        // Create a void method named PerformOperation. This method takes two integer parameters because the method is void, it does not return a value
        public void PerformOperation(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first number
            int result = firstNumber * 2;

            // Display the result of the math operation
            Console.WriteLine("First number multiplied by 2: " + result);

            // Display the second number to the screen
            Console.WriteLine("Second number: " + secondNumber);
        }
    }
}