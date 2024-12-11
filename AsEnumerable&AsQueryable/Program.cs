namespace AsEnumerable_AsQueryable;

record Person(string Name, int Age);
internal class Program
{
    static void Main(string[] args)
    {
        List<Person> list = new List<Person>()
        {
            new Person("John", 25),
            new Person("Jane", 30),
            new Person("Bob", 35)
        };

        IEnumerable<Person> enumerable = list.AsEnumerable();  // convert List to IEnumerable

        IQueryable<Person> queryable = list.AsQueryable();  // convert List to IQueryable
    }
}

