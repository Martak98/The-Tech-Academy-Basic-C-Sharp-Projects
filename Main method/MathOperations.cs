// Import the System namespace so we can use built-in classes and methods
using System;

// Create a namespace for the application
namespace OverloadedMethodsApp
{
    // Create a class called MathOperations
    public class MathOperations
    {
        // First overloaded method: This method accepts an integer parameter it adds 20 to the number and returns the result as an integer
        public int DoMath(int number)
        {
            // Perform addition and return the result
            return number + 20;
        }

        // Second overloaded method: This method accepts a decimal parameter it multiplies the decimal by 2 then converts the result into an integer before returning it
        public int DoMath(decimal number)
        {
            // Multiply the decimal value by 2
            decimal result = number * 2;

            // Convert the decimal result into an integer explicit casting removes the decimal portion
            return (int)result;
        }

        // Third overloaded method: this method accepts a string parameter it attempts to convert the string into an integer if successful, it subtracts 5 from the number then returns the result as an integer
        public int DoMath(string number)
        {
            // Create a variable to store the converted integer
            int convertedNumber;

            // Try to convert the string into an integer
            bool success = int.TryParse(number, out convertedNumber);

            // Check whether the conversion worked
            if (success)
            {
                // Perform subtraction and return the result
                return convertedNumber - 5;
            }
            else
            {
                // If conversion fails, display an error message
                Console.WriteLine("The string could not be converted to an integer.");

                // Return 0 as a default value
                return 0;
            }
        }
    }
}