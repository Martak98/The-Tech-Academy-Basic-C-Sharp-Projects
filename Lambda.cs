using System;
using System.Collections.Generic;
using System.Linq;

// Define the Employee class.
public class Employee
{
    // Property to store the employee's unique ID.
    public int Id { get; set; }

    // Property to store the employee's first name.
    public string FirstName { get; set; }

    // Property to store the employee's last name.
    public string LastName { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a list of Employee objects.
        List<Employee> employees = new List<Employee>()
        {
            new Employee { Id = 1, FirstName = "Joe", LastName = "Smith" },
            new Employee { Id = 2, FirstName = "Joe", LastName = "Johnson" },
            new Employee { Id = 3, FirstName = "Mary", LastName = "Brown" },
            new Employee { Id = 4, FirstName = "John", LastName = "Davis" },
            new Employee { Id = 5, FirstName = "Sarah", LastName = "Wilson" },
            new Employee { Id = 6, FirstName = "Michael", LastName = "Taylor" },
            new Employee { Id = 7, FirstName = "Emma", LastName = "Anderson" },
            new Employee { Id = 8, FirstName = "David", LastName = "Thomas" },
            new Employee { Id = 9, FirstName = "Olivia", LastName = "Jackson" },
            new Employee { Id = 10, FirstName = "James", LastName = "White" }
        };

        // Create an empty list that will store employees whose first name is "Joe".
        List<Employee> joeEmployees = new List<Employee>();

        // Loop through every employee in the employees list.
        foreach (Employee employee in employees)
        {
            // Check whether the employee's FirstName property is equal to "Joe".
            if (employee.FirstName == "Joe")
            {
                // If the employee's first name is "Joe", add the employee object to the new list.
                joeEmployees.Add(employee);
            }
        }

        // Display a heading for the foreach loop results.
        Console.WriteLine("Employees named Joe (foreach loop):");

        // Loop through the filtered list and display each employee.
        foreach (Employee employee in joeEmployees)
        {
            Console.WriteLine(
                $"ID: {employee.Id}, Name: {employee.FirstName} {employee.LastName}"
            );
        }

        // Create a new list of employees named "Joe" using a lambda expression with the Where method.
        List<Employee> joeEmployeesLambda = employees
            .Where(employee => employee.FirstName == "Joe")
            .ToList();

        // Display a heading for the lambda expression results.
        Console.WriteLine("\nEmployees named Joe (lambda expression):");

        // Loop through the lambda-filtered list and display each employee.
        foreach (Employee employee in joeEmployeesLambda)
        {
            Console.WriteLine(
                $"ID: {employee.Id}, Name: {employee.FirstName} {employee.LastName}"
            );
        }

        // Create a new list containing employees whose Id is greater than 5 using a lambda expression.
        List<Employee> employeesWithIdGreaterThanFive = employees
            .Where(employee => employee.Id > 5)
            .ToList();

        // Display a heading for employees with Ids greater than 5.
        Console.WriteLine("\nEmployees with ID greater than 5:");

        // Loop through the filtered list and display each employee.
        foreach (Employee employee in employeesWithIdGreaterThanFive)
        {
            Console.WriteLine(
                $"ID: {employee.Id}, Name: {employee.FirstName} {employee.LastName}"
            );
        }

        // Pause the application so the user can view the output before the console window closes.
        Console.ReadLine();
    }
}