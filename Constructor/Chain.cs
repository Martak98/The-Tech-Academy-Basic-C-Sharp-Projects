using System;

namespace ConstructorAssignment
{
    // Define a public class named Chain.
    public class Chain
    {
        // Constructor that accepts a float value.
        public Chain(float num1) : this(num1, "Anthony")
        {
            // Display the number provided by the user and the default name.
            Console.WriteLine(num1 + " and your default name is " + Name);
        }
         // Constructor that accepts a string value.
        public Chain(string name1) : this(35, name1)
        {
            // Display the name provided by the user and the default favorite number.
            Console.WriteLine(name1 + " and your default favourtie number is " + Num);
        }
        // Main constructor that accepts both a number and a name.
        public Chain (float num, string name)
        {
             // Assign the value of the name parameter to the Name property.
            Name = name;
             // Assign the value of the name parameter to the Num property.
            Num = num;
        }
        // Private auto-implemented property used to store a name.
        string Name { get; set; }
        // Private auto-implemented property used to store a number.
        float Num { get; set; }
    }
}