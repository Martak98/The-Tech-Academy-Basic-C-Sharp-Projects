using System;

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
}