namespace ToDictionary;


record Employee(int Id, string Name, int Age);
internal class Program
{
    static void Main(string[] args)
    {
        // the key which i choose must be unique else it will throw exception

        // ex1
        IEnumerable<int> collection = [1, 2, 3];
        var dictionary = collection.ToDictionary(key => key, value => value * 2);

        foreach (var item in dictionary)
        {
            Console.WriteLine($" key : {item.Key} , value : {item.Value}");
        }

        //output =>
        // key : 1 , value : 2
        // key : 2 , value : 4
        // key : 3 , value : 6



        //ex2

        IEnumerable<Employee> employees = new List<Employee>()
        {
            new Employee(1 ,"amr", 22 ),
            new Employee(2 ,"ahmed", 25 ),
            new Employee(3 ,"mohamed", 26 ),
        };


        Dictionary<int, string> dictionary2 = employees.ToDictionary(emp => emp.Id, emp => emp.Name);

        foreach (var item in dictionary2)
        {
            Console.WriteLine($" key : {item.Key} , value : {item.Value}");
        }

        //output =>
        // key : 1 , value : amr
        // key : 2 , value : ahmed
        // key : 3 , value : mohamed

        Console.ReadKey();


    }

}
