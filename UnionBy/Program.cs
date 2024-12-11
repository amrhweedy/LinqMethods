namespace UnionBy;

public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
}

internal class Program
{
    static void Main(string[] args)
    {
        // unionBy=> it make a union between the 2 collections but remove the duplicates based on the key which is the id
        IEnumerable<Employee> collections1 = new List<Employee>()
        {
            new Employee {Id = 1 , Name = "amr" , Age = 25},
            new Employee {Id = 1 , Name = "mona" , Age = 26},
            new Employee {Id = 2 , Name = "ali" , Age = 26}
        };

        IEnumerable<Employee> collections2 = new List<Employee>()
        {
            new Employee {Id = 1 , Name = "omar" , Age = 25},
            new Employee {Id = 2 , Name = "ahmed" , Age = 26},
            new Employee {Id = 3 , Name = "mohamed" , Age = 26}
        };

        IEnumerable<Employee> employees = collections1.UnionBy(collections2, e => e.Id);
    //    IEnumerable<Employee> employees = collections1.UnionBy(collections2, e => new { e.Id, e.Name }); // if i need to remove the duplicated based on the id and the name
        foreach (Employee employee in employees)
        {
            Console.WriteLine($" id : {employee.Id} ,name :{employee.Name} , age :{employee.Age}");
        }
        Console.ReadKey();

        // output =>
        // id: 1 ,name: amr , age: 25
        // id: 2 ,name: ali , age: 26
        // id: 3 ,name: mohamed , age: 26



        // IntersectBy and ExceptBy like the same UnionBy the common between then are they are remove the duplicates based on the key
        // they are use mostly which reference data types not primitive data types
        // they are differed execution


       

    }
}
