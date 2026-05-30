using System;

// Define the namespace for the application.
namespace AgeCalculator
{
    // Main program class.
    class Program
    {
        // Entry point of the application.
        static void Main(string[] args)
        {
            try
            {
                // Ask the user to enter their age.
                Console.WriteLine("Please enter your age:");

                // Read the user's input from the console and store it as a string.
                string input = Console.ReadLine();

                // Convert the user's input to an integer.
                int age = Convert.ToInt32(input);

                // Check if the age entered is zero or a negative number.
                if (age <= 0)
                {
                    // Throw an exception with a custom message if the age is invalid.
                    throw new ArgumentException("Age cannot be zero or a negative number.");
                }

                // Get the current year from the system clock.
                int currentYear = DateTime.Now.Year;

                // Calculate the user's birth year by subtracting their age from the current year.
                int birthYear = currentYear - age;

                // Display the calculated birth year to the user.
                Console.WriteLine("You were born in approximately: " + birthYear);
            }
            // Catch exceptions caused by invalid age values.
            catch (ArgumentException ex)
            {
                // Display the custom error message to the user.
                Console.WriteLine("Error: " + ex.Message);
            }
            // Catch all other exceptions that may occur.
            catch (Exception)
            {
                // Display a general error message.
                Console.WriteLine("An error occurred. Please enter a valid whole number.");
            }

            // Keep the console window open until the user presses Enter.
            Console.ReadLine();
        }
    }
}