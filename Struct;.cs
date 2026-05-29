using System;

// Define a struct named Number.
public struct Number
{
    // Create a property named Amount of type decimal.
    public decimal Amount { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Number struct.
        Number myNumber = new Number();

        // Assign a decimal value to the Amount property.
        myNumber.Amount = 123.45m;

        // Display the value stored in the Amount property to the console.
        Console.WriteLine("The amount is: " + myNumber.Amount);

        // Pause the program so the user can read the output before the console window closes.
        Console.ReadLine();
    }
}