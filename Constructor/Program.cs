using System;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main (string[] args)
        {
            //Creating a const variable
            const string const1 = "Your name is: ";
            const string const2 = "Your favourite number is: ";
            Console.WriteLine("Enter your name or favourite number: ");
            // Read the user's input from the console and store it in the variable answer.
            var answer = Console.ReadLine();
            // Attempt to convert the user's input to a float value.
            if (float.TryParse(answer, out float x))
            {
                 // Display the value stored in const2.
                Console.WriteLine(const2);
                 // Create a new Chain object using the constructor that accepts a float.
                Chain newChain = new Chain(x);
                 // Keep the console window open until the user presses Enter.
                Console.ReadLine();
            }
            else
            {
                 // Display the value stored in const1.
                Console.WriteLine(const1);
                 // Create a new Chain object using the constructor that accepts a string.
                Chain newChain = new Chain(answer);
                Console.ReadLine();
            }
        }
    }
}