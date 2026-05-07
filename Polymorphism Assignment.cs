// Import the basic System namespace so we can use Console and other built-in classes
using System;

namespace PolymorphismAssignment
{
    // Create an interface named IQuittable
    // Interfaces define methods that classes must implement
    interface IQuittable
    {
        // Declare a method named Quit with no return value
        void Quit();
    }

    // Create an Employee class
    // The colon (:) means Employee inherits from the IQuittable interface
    class Employee : IQuittable
    {
        // Create a public property for the employee's first name
        public string FirstName { get; set; }

        // Create a public property for the employee's last name
        public string LastName { get; set; }

        // Implement the Quit() method required by the interface
        // Because Employee uses IQuittable, it MUST include this method
        public void Quit()
        {
            // Display a message showing that the employee has quit
            Console.WriteLine(FirstName + " " + LastName + " has quit the company.");
        }
    }

    // Main program class
    class Program
    {
        // Main method - this is where the application starts running
        static void Main(string[] args)
        {
            // Create a new Employee object and assign values to properties
            Employee employee = new Employee()
            {
                FirstName = "John",
                LastName = "Doe"
            };

            // Use polymorphism:
            // Create an object of interface type IQuittable
            // and assign it an Employee object because Employee implements IQuittable
            IQuittable quittableEmployee = employee;

            // Call the Quit() method using the interface object
            quittableEmployee.Quit();

            // Pause the console window so the user can see the output
            Console.ReadLine();
        }
    }
}
