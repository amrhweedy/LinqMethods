namespace Where;

internal class Program
{
    static void Main(string[] args)
    {

        //Where are deferred execution methods. They return a new enumerable sequence without modifying the original collection.
        // the collections and result not saved in the memeory because they are iEnumerable it means differed execution
        // when i loop for result this line will be executed  collections.where(x=>x>2) and this where will return a new collection
        // any linq method returns IEnumerable or IQueryable is differed execution, and they create a new collections not modify in the original collections
        IEnumerable<int> collections = [1, 2, 3, 4, 5];
        IEnumerable<int> result = collections.Where(x => x > 2);


        foreach (var item in result)
        {
            Console.WriteLine(item);
        }

        //result => 3,4,5   

        Console.ReadKey();
    }
}
