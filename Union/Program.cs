namespace Union;

internal class Program
{
    static void Main(string[] args)
    {
        // notion
        // The Union method in LINQ is used to combine two sequences into a single sequence that contains distinct elements from both sequences. It ensures that duplicates are removed from the resulting collection.
        // differed execution

        IEnumerable<int> collection1 = [1, 2, 3];
        IEnumerable<int> collection2 = [2, 3, 4];

        IEnumerable<int> result = collection1.Union(collection2);

        foreach (var item in result)
        {
            Console.WriteLine(item);    // 1,2,3,4
        }

        Console.ReadKey();
    }
}
