// Import the System namespace so we can use Console methods
using System;

// Create a static class named MathHelper
// A static class cannot be instantiated
// It is used to store utility methods
static class MathHelper
{
    // Create a void method named DivideByTwo. This method takes an integer input then divides it by 2 and stores the result in the output parameter
    public static void DivideByTwo(int number, out int result)
    {
        // Divide the number by 2
        result = number / 2;
    }

    // Overloaded method: This method has the same name but different parameters it accepts a decimal value instead of an integer
    public static void DivideByTwo(decimal number, out decimal result)
    {
        // Divide the decimal number by 2
        result = number / 2;
    }
}