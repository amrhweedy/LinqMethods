namespace GroupBy;

record Person(string Name, int Age);
internal class Program
{
    //The GroupBy method in LINQ is used to group elements of a collection based on a key that you specify.
    //It produces a sequence of groups, where each group consists of elements that share the same key. The result of GroupBy is an IEnumerable<IGrouping<TKey, TElement>>, where TKey is the type of the key and TElement is the type of the elements in the original collection.
    static void Main(string[] args)
    {
        IEnumerable<Person> persons = new List<Person>()
        {
            new("amr" , 25),
            new("ali",25),
            new("omar" ,22)
        };

      IEnumerable<IGrouping<int, Person>> groups =   persons.GroupBy(p => p.Age); // the key here is age, we make groups by the age
      
        foreach(var group in groups)
        {
             Console.WriteLine($"age: {group.Key}");
            foreach(var person in  group)
            {
                Console.WriteLine($" name : {person.Name}");
            }
        }
     }

    // output =>
    // age: 22
    //    name : omar
    // age: 25
    //    name : amr
    //    name : ali

}
