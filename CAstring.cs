using System;
using System.Collections.Gemeric;

class Program
{
    static void Main(string[] args)
    {
        //Create a list of integers
        List<int> intList = new List<int>() { 11, 34, 20, 46, 13, 115, 7622, 123, 15, 346 };
        //Ask the user for input and loop through the list dividing each number by the input
        bool numValid = false;
        while (!numValid)
        {
            //Using a try/catch block to give an error message
            try
            {
                Console.WriteLine("\nEnter a number to divide the above liost by: ");
                float numDivide = float.Parse(Console.ReadLine());
                //If statment to check if the user entered 0
                if (numDivide == 0)
                {
                    Console.WriteLine("Please enter a number other than 0.");
                }
                //Dividing each number in the list by the input
                else
                {
                    foreach (int num in intList)
                    {
                        float Divide = num / numDivide;
                       Console.WriteLine(num + "/" + numDivide + "=" + Divide);
                    }
                    numValid = true;
                }
            }
            //Catch block to display error message for sting input
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
                //Message to let the user know the program has exited the try/catch block
                Console.WriteLine("The program has exited the try/catch block.");
    }
}