using System;

// Define the Employee class
public class Employee
{
    // Property to store the employee's unique ID
    public int Id { get; set; }

    // Property to store the employee's first name
    public string FirstName { get; set; }

    // Property to store the employee's last name
    public string LastName { get; set; }

    // Overload the == operator so two Employee objects
    // are considered equal if their Id values match
    public static bool operator ==(Employee employee1, Employee employee2)
    {
        // Check if both references point to the same object
        if (ReferenceEquals(employee1, employee2))
        {
            return true;
        }

        // Check if either object is null
        if (employee1 is null || employee2 is null)
        {
            return false;
        }

        // Compare the Id properties of both employees
        return employee1.Id == employee2.Id;
    }

    // Overload the != operator.
    public static bool operator !=(Employee employee1, Employee employee2)
    {
        // Return the opposite result of the == operator
        return !(employee1 == employee2);
    }

    // Override Equals so it behaves consistently with the == operator
    public override bool Equals(object obj)
    {
        // Check if the object is an Employee
        if (obj is Employee employee)
        {
            // Compare the Id values
            return this.Id == employee.Id;
        }

        // Return false if the object is not an Employee
        return false;
    }

    // Override GetHashCode whenever Equals is overridden
    public override int GetHashCode()
    {
        // Use the Id property's hash code
        return Id.GetHashCode();
    }
}

// Main program class
class Program
{
    static void Main(string[] args)
    {
        // Create the first Employee object
        Employee employee1 = new Employee
        {
            Id = 1,
            FirstName = "John",
            LastName = "Smith"
        };

        // Create the second Employee object
        Employee employee2 = new Employee
        {
            Id = 1,
            FirstName = "Jane",
            LastName = "Doe"
        };

        // Use the overloaded == operator to compare the employees
        bool areEqual = employee1 == employee2;

        // Display the result of the comparison
        Console.WriteLine($"Are the employees equal? {areEqual}");

        // Wait for user input before closing the application
        Console.ReadLine();
    }
}