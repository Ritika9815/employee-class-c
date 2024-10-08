// IQuittable interface declaration
public interface IQuittable
{
    // Quit method to be implemented by any class that inherits from IQuittable
    void Quit();
}
// Employee class inherits from IQuittable
public class Employee : IQuittable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Quit method implementation from IQuittable
    public void Quit()
    {
        // You can customize the implementation as per your needs
        Console.WriteLine($"{FirstName} {LastName} has quit the job.");
    }
}
// Main method to run the application
class Program
{
    static void Main(string[] args)
    {
        // Create an Employee object
        Employee employee = new Employee()
        {
            FirstName = "John",
            LastName = "Doe"
        };

        // Polymorphism - object of type IQuittable
        IQuittable quittable = employee;

        // Call the Quit method from the IQuittable interface
        quittable.Quit();

        // Keep console window open
        Console.ReadLine();
    }
}
