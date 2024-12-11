namespace DistinctBy;


public class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
}
internal class Program
{
    static void Main(string[] args)
    {
        //The DistinctBy method in LINQ is used to remove duplicate elements from a collection based on a specific key. Unlike Distinct, which compares entire elements for uniqueness, DistinctBy allows you to define a key selector function to determine which property or value to use for uniqueness.
        // differed execution 
        // notion

        var employees = new List<Employee>
        {
            new Employee { Name = "Alice", Age = 25 },
            new Employee { Name = "Bob", Age = 30 },
            new Employee { Name = "Alice", Age = 35 }, // Duplicate by Name
            new Employee { Name = "Charlie", Age = 40 }
        };


        // Using DistinctBy to remove duplicates based on the 'Name' property

        IEnumerable<Employee> distinctEmployees = employees.DistinctBy(e => e.Name);

        foreach (var employee in distinctEmployees)
        {
            Console.WriteLine($" name : {employee.Name} , age : {employee.Age}");
        }

        // output =>  Distinct Employees by Name:
        //  Name: Alice, Age: 25
        // Name: Bob, Age: 30
        // Name: Charlie, Age: 40

        //the second Alice (with Age = 35) is excluded because its Name property matches the first Alice.



        Console.ReadKey();


    }
}
