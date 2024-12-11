namespace ToLookup__;

internal class Program
{
    record Person(string Name, int Age);
    static void Main(string[] args)
    {
        //The ToLookup LINQ method in C# creates a Lookup<TKey, TElement>, which is similar to a dictionary but designed for scenarios where multiple values are associated with the same key
        // Groups elements in a sequence by their keys.
        // Allows multiple elements to share the same key, unlike a dictionary, which requires keys to be unique.
        // immediate execution
        // notion

        IEnumerable<Person> persons = new List<Person>()
        {
            new Person("amr" , 15),
            new Person("ahmed" , 15),
            new Person("ali" , 20)
        };

        ILookup<int, Person> lookup = persons.ToLookup(x => x.Age);  // the key her is age so the lookup is 2 groups (the key is age) so the first group contains 2 person and the second group contains 1 person
        foreach (var group in lookup)  // the group is a type of IGrouping<int,person>  
        {
            Console.WriteLine($"key : {group.Key}");   // every group has a key but the key is not a unique it means the group contains more than one person

            foreach (var item in group)
            {
                Console.WriteLine($" =>>>> name : {item.Name} , age : {item.Age}");
            }
        }

        // output :
        // key : 15
        // =>>>> name : amr , age : 15
        // =>>>> name : ahmed , age : 15
        // key : 20
        // =>>>> name : ali , age : 20
        Console.ReadKey();

    }
}
