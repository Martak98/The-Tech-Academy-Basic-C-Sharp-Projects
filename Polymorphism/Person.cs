using System;

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