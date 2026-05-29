using System;

// Create an enum that represents the days of the week.
public enum DaysOfWeek
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Ask the user to enter the current day of the week.
            Console.WriteLine("Please enter the current day of the week:");

            // Read the user's input from the console and store it as a string.
            string userInput = Console.ReadLine();

            // Convert the user's input into a DaysOfWeek enum value.
            // The third parameter (true) makes the conversion
            // case-insensitive, so "monday", "MONDAY", and "Monday"
            // are all accepted.
            DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(
                typeof(DaysOfWeek),
                userInput,
                true
            );

            // Display the successfully parsed day back to the user.
            Console.WriteLine("You entered: " + currentDay);
        }
        catch (Exception)
        {
           
            // This catch block handles that error and displays a helpful message to the user.
            Console.WriteLine("Please enter an actual day of the week.");
        }

        // Pause the program so the user can read the output before the console window closes.
        Console.ReadLine();
    }
}