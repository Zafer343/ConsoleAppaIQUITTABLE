using System;

// Define the IQuittable interface with a single method Quit.
public interface IQuittable
{
    // Define a method signature for Quit with no implementation.
    void Quit();
}

// Modify the existing Employee class to inherit from the IQuittable interface.
public class Employee : IQuittable
{
    // Properties to get/set employee ID, first name, and last name.
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Implement the Quit method from the IQuittable interface.
    public void Quit()
    {
        // Write to the console that the employee has quit. This is a simple implementation.
        Console.WriteLine($"{FirstName} {LastName} (ID: {Id}) has quit the job.");
    }
}

class Program
{
    static void Main()
    {
        // Instantiate a new Employee object.
        Employee emp1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };

        // Use polymorphism to create an IQuittable reference to an Employee object.
        IQuittable quittableEmp = emp1;

        // Call the Quit method on the quittableEmp instance.
        quittableEmp.Quit();

        // Wait for the user to press a key before closing the console window.
        Console.ReadKey();
    }
}
