namespace Except;

internal class Program
{
    static void Main(string[] args)
    {
        // The Except LINQ method is used to produce the set difference of two sequences.
        // It returns a new sequence containing elements from the first sequence that do not appear in the second sequence.
        // Duplicates are removed, and the comparison is based on the default equality comparer unless a custom comparer is provided.
        IEnumerable<int> collection1 = [1, 2, 3, 3, 4];
        IEnumerable<int> collection2 = [4, 5, 6];

        IEnumerable<int> result = collection1.Except(collection2);  // differed execution

        foreach (var item in result)
        {
            Console.WriteLine(item);  // 1 , 2 , 3
        }

        Console.ReadKey();
    }
}
