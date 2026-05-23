// Import the System namespace
using System;

// Create a namespace for the application
namespace OptionalParameterApp
{
    // Create a class called MathOperations
    public class MathOperations
    {
        // Create a method named AddNumbers
        public int AddNumbers(int firstNumber, int secondNumber = 0)
        {
            // Perform a math operation by adding the two numbers together
            int result = firstNumber + secondNumber;

            // Return the result to the calling code
            return result;
        }
    }