using System;                         
using System.IO;                       // Allows working with files (StreamWriter, File, etc.)

namespace NumberLogger                 
{
    class Program                     
    {
         // Entry point of the program
        static void Main(string[] args)  
        {
            // Ask the user to enter a number
            Console.WriteLine("Please enter a number:");

            // Read user input from the console and store it as a string
            string input = Console.ReadLine();

            // Define the file path where the number will be saved
            string filePath = "numbers.txt";

            // Write the number to a text file (overwrites file if it already exists)
            File.WriteAllText(filePath, input);

            // Inform the user that the number has been saved
            Console.WriteLine("Your number has been saved to a file.");

            // Read the contents of the file back into the program
            string fileContent = File.ReadAllText(filePath);

            // Display the contents of the file to the user
            Console.WriteLine("The number stored in the file is:");
            Console.WriteLine(fileContent);

            // Wait for user input before closing the program (so console stays open)
            Console.ReadLine();
        }
    }
}