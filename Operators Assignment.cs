// Define a namespace for organizing the classes in the application
namespace EmployeeComparisonApp
{
    // Create the Employee class
    public class Employee
    {
        // Property to store the employee's ID
        public int Id { get; set; }

        // Property to store the employee's first name
        public string FirstName { get; set; }

        // Property to store the employee's last name
        public string LastName { get; set; }

        // Overload the == operator so two Employee objects
        // are considered equal when their Id values match
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // Check if both objects are null
            if (ReferenceEquals(emp1, emp2))
            {
                return true;
            }

            // Check if either object is null
            if (emp1 is null || emp2 is null)
            {
                return false;
            }

            // Compare the Id properties of both Employee objects
            return emp1.Id == emp2.Id;
        }

        // Overload the != operator
        // This must be paired with the == operator
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            // Return the opposite result of the == operator
            return !(emp1 == emp2);
        }

        // Override the Equals method for consistency with == operator
        public override bool Equals(object obj)
        {
            // Check if the object passed in is an Employee
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
            // Return the hash code of the Id property
            return Id.GetHashCode();
        }
    }
}

// Import the namespace that contains the Employee class
using EmployeeComparisonApp;

// Create a namespace for the application
namespace EmployeeComparisonApp
{
    // Main program class
    class Program
    {
        // Entry point of the console application
        static void Main(string[] args)
        {
            // Create the first Employee object
            Employee employee1 = new Employee();

            // Assign values to the first employee's properties
            employee1.Id = 1;
            employee1.FirstName = "John";
            employee1.LastName = "Smith";

            // Create the second Employee object
            Employee employee2 = new Employee();

            // Assign values to the second employee's properties
            employee2.Id = 1;
            employee2.FirstName = "Jane";
            employee2.LastName = "Doe";

            // Compare the two Employee objects using the overloaded == operator
            bool areEqual = employee1 == employee2;

            // Display the comparison result in the console
            Console.WriteLine("Are the employees equal? " + areEqual);

            // Compare the two Employee objects using the overloaded != operator
            bool areNotEqual = employee1 != employee2;

            // Display the inequality comparison result
            Console.WriteLine("Are the employees not equal? " + areNotEqual);

            // Pause the console window so the user can see the output
            Console.ReadLine();
        }
    }
}
