using System;

// Define the Employee class.
public class Employee : Person, IQuittable
{
    // Override the abstract SayName() method inherited from Person.
    public override void SayName()
    {
        // Display the employee's full name in the console.
        Console.WriteLine("Name: " + firstName + " " + lastName);
    }

    // Implement the Quit() method required by the IQuittable interface.
    public void Quit()
    {
        // Display a message indicating that the employee has quit.
        Console.WriteLine(firstName + " " + lastName + " has quit the company.");
    }
}