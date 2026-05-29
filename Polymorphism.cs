using System;

// Define an interface named IQuittable.
public interface IQuittable
{
    // Declare a method named Quit().
    void Quit();
}

// Define an abstract base class named Person.
public abstract class Person
{
    // Property to store the person's first name.
    public string firstName { get; set; }

    // Property to store the person's last name.
    public string lastName { get; set; }

    // Abstract method that must be implemented by derived classes.
    public abstract void SayName();
}

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

// Main program class.
class Program
{
    // Entry point of the application.
    static void Main(string[] args)
    {
        // Create an Employee object and initialize its properties.
        Employee employee = new Employee
        {
            firstName = "Sample",
            lastName = "Student"
        };

        // Call the SayName() method to display the employee's name.
        employee.SayName();

        // Create an object of type IQuittable and assign it an Employee instance.
        IQuittable quittableEmployee = employee;

        // Call the Quit() method through the interface reference.
        quittableEmployee.Quit();

        // Keep the console window open until the user presses Enter.
        Console.ReadLine();
    }