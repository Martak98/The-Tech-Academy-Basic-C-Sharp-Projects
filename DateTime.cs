using System; 

namespace TimeCalculatorApp 
{
    class Program 
    {
        static void Main(string[] args) 
        
            // Print the current date and time to the console
            DateTime currentTime = DateTime.Now; // Gets the current local system time
            Console.WriteLine("Current date and time: " + currentTime); // Displays it to the user

            // Ask the user to enter a number of hours
            Console.WriteLine("Please enter a number of hours:");

            // Read user input from the console as a string
            string input = Console.ReadLine();

            // Convert the input string into an integer (number of hours)
            int hours;

            // Try to safely convert the input into a number
            bool isNumber = int.TryParse(input, out hours);

            // Check if the input was a valid number
            if (isNumber)
            {
                // Calculate future time by adding the user-defined number of hours
                DateTime futureTime = currentTime.AddHours(hours);

                // Print the result to the console
                Console.WriteLine("In " + hours + " hour(s), the time will be: " + futureTime);
            }
            else
            {
                // Handle invalid input (non-numeric values)
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            // Keeps the console window open until the user presses Enter
            Console.ReadLine();
        }
    }
}