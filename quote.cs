using System;
namespace PackageExpress //Creates a namespace to group our program
{
    class Program //Defines the main program class
    {
        static void Main(string[] args) //Entry point of the console application
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instruction below."); //Display the welcome meggase
            Console.WriteLine("Please enter the package weight:"); //Asking for package weight
            int weight = Convert.ToInt32(Console.ReadLine()); //Reads the input and convert it to an integer
            if (weight > 50)
            {
                Console.WriteLine("Package to heavy to be shipped via Package Express. Have a good day."); //Display an error meggase if package is too heavy
                return; //End the program
            }
            Console.WriteLine("Please enter the package width:"); //Asking for package width
            int width = Convert.ToInt32(Console.ReadLine()); //Read and convert width
            Console.WriteLine("Please enter the package height:"); //Asking for packahe height
            int height = Convert.ToInt32(Console.ReadLine()); //Read and convert height
            Console.WriteLine("Please enter the package lenght:"); //Asking for package lenght
            int lenght = Console.ToInt32(Console.ReadLine()); //Read nad convert lenght
            int dimensionTotal = width + height + lenght; //Calculate total dimension
            if (dimensionTotal > 50) //checking if dimmension is grater than 50 
            {
                Console.WriteLine("Package too big to be shipped via Parcel Express."); //Display an error message if combined dimmension is grater than 50
                return; //Ends the program immediately
            }
            int volume = width * height * lenght; //Multiply all dimensions
            int totalCostRaw = volume * weight; //Multiply volume by weight
            decimal quote = totalCostRaw / 100m; //Divide the result by 100 to get the final shipping quote
            Console.WriteLine("Your estimated total for shipping this package is : $" + quote.ToString(0.00)); //Displaying the final quote
            Console.WriteLine("Thank you!"); //Displaying thank you message

        }
    }
}