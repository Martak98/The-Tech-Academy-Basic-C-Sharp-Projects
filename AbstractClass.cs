using System;

// Define an abstract class named Person.
public abstract class Person
{
    // Public property to store the person's first name.
    public string firstName { get; set; }

    // Public property to store the person's last name.
    public string lastName { get; set; }

    // Abstract method declaration.
    public abstract void SayName();
}

// Define the Employee class and inherit from Person.
public class Employee : Person
{
    // Override the abstract SayName() method from the Person class.
    public override void SayName()
    {
        // Display the employee's full name in the console.
        Console.WriteLine("Name: " + firstName + " " + lastName);
    }
}

// Main program class.
class Program
{
    // Entry point of the application.
    static void Main(string[] args)
    {
        // Create a new Employee object.
        Employee employee = new Employee();

        // Assign a value to the firstName property.
        employee.firstName = "Sample";

        // Assign a value to the lastName property.
        employee.lastName = "Student";

        // Call the SayName() method.
        // This will display the employee's full name.
        employee.SayName();

        // Pause the console window so the user can see the output.
        Console.ReadLine();
    }
}