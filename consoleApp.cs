using System;
using System.Collections.Generic;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // -------------------------------
            // PART 1: Array + user input
            // -------------------------------

            // Create a one-dimensional array of strings
            string[] stringArray = { "Apple", "Banana", "Cherry", "Date" };

            // Ask the user to input some text
            Console.WriteLine("Enter some text to append to each item:");
            string userInput = Console.ReadLine();

            // Loop through array and append user input to each string
            for (int i = 0; i < stringArray.Length; i++)
            {
                // Append user input to each element
                stringArray[i] += userInput;
            }

            // Second loop to print each string
            Console.WriteLine("\nUpdated array:");
            foreach (string item in stringArray)
            {
                Console.WriteLine(item);
            }

            // -------------------------------
            // PART 2: Infinite loop (fixed)
            // -------------------------------

            Console.WriteLine("\nDemonstrating fixed loop:");

            // ORIGINAL infinite loop (commented out because it would never stop)
            int counter = 0;
            while (counter < 3) // Fix: condition prevents infinite execution
            {
                Console.WriteLine("Loop iteration: " + counter);
                counter++; // Increment ensures loop will eventually stop
            }

            // -------------------------------
            // PART 3: < and <= loops
            // -------------------------------

            Console.WriteLine("\nLoop using < operator:");
            // Loop using < operator
            for (int i = 0; i < 3; i++) // Runs while i is less than 3
            {
                Console.WriteLine("i = " + i);
            }

            Console.WriteLine("\nLoop using <= operator:");
            // Loop using <= operator
            for (int i = 0; i <= 3; i++) // Runs while i is less than or equal to 3
            {
                Console.WriteLine("i = " + i);
            }

            // -------------------------------
            // PART 4: Search in unique list
            // -------------------------------

            // Create list with unique items
            List<string> uniqueList = new List<string> { "Red", "Green", "Blue", "Yellow" };

            Console.WriteLine("\nEnter a color to search:");
            string searchInput = Console.ReadLine();

            bool found = false;

            // Loop through list to find match
            for (int i = 0; i < uniqueList.Count; i++)
            {
                if (uniqueList[i].Equals(searchInput, StringComparison.OrdinalIgnoreCase))
                {
                    // Display index of match
                    Console.WriteLine("Found at index: " + i);
                    found = true;

                    // Stop loop once match is found
                    break;
                }
            }

            // If no match found, notify user
            if (!found)
            {
                Console.WriteLine("Your input is not on the list.");
            }

            // -------------------------------
            // PART 5: List with duplicates (find all matches)
            // -------------------------------

            // Create list with duplicate items
            List<string> duplicateList = new List<string> { "Cat", "Dog", "Bird", "Cat", "Fish", "Dog" };

            Console.WriteLine("\nEnter an animal to search:");
            string searchDuplicate = Console.ReadLine();

            bool foundDuplicate = false;

            // Loop through list to find ALL matches (no break)
            for (int i = 0; i < duplicateList.Count; i++)
            {
                if (duplicateList[i].Equals(searchDuplicate, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Match found at index: " + i);
                    foundDuplicate = true;
                }
            }

            // If no match found
            if (!foundDuplicate)
            {
                Console.WriteLine("Your input is not on the list.");
            }

            // -------------------------------
            // PART 6: Detect duplicates using foreach
            // -------------------------------

            // Create list with duplicates
            List<string> items = new List<string> { "A", "B", "C", "D", "C" };

            // Create a HashSet to track seen items
            HashSet<string> seenItems = new HashSet<string>();

            Console.WriteLine("\nChecking for duplicates:");

            // Loop through each item in list
            foreach (string item in items)
            {
                // If item already exists in HashSet, it's a duplicate
                if (seenItems.Contains(item))
                {
                    Console.WriteLine(item + " - this item is a duplicate");
                }
                else
                {
                    Console.WriteLine(item + " - this item is unique");
                    seenItems.Add(item); // Add new item to HashSet
                }
            }

            // -------------------------------
            // End of program
            // -------------------------------

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}