using System;

namespace MethodsAndObjectsAssigment
{
    public class Person
    {
        //Creating a class called Person, giving it two properties, each one is data type string
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Giving the calss a void method called SayName that takes no parimeters and writes the person's name
        public void SayName()
        {
            Console.WriteLine("Name: " + this.FirstName + " " + this.LastName);
        }
    }
}

using System;

namespace MethodsAndObjectsAssignment
{
    //Creating second class named Employee and inherit it from Person class
    public class Employee : Person
    {
        //Giving the employee class a property named Id and have it be of data type int
        public int Id {get; set; }
    }
}

using System;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instatntiate and initialize an employee object inside Main method
            Employee sam = new Employee() {FirstName = "Sample", LastName = "Student"};
            //Call the superclass method SayName() on the Employee object
            sam.SayName();
            Console.ReadLine();
        }
    }
}