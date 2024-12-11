namespace InterSect;

internal class Program
{
    static void Main(string[] args)
    {
        // The Intersect LINQ method is used to find the common elements between two sequences. It returns a sequence containing elements that exist in both collections, removing any duplicates.
        IEnumerable<int> collection1 = [1, 2, 3];
        IEnumerable<int> collection2 = [2, 3, 4, 3];

        IEnumerable<int> result = collection1.Intersect(collection2);  // differed execution

        foreach (var item in result)
        {
            Console.WriteLine(item);   // 2,3 
        }

        Console.ReadKey();
    }
}
