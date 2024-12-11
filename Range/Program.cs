namespace Range;

internal class Program
{
    static void Main(string[] args)
    {
        // Range method in linq is used to create a range of numbers  , differed execution

        // ex => i need to create a collection of numbers from 1 to 100
        IEnumerable<int> collection = Enumerable.Range(0, 100);  // 0 is the start but the 100 is the count so the result will be 0 to 99

        foreach (var item in collection)
        {
            Console.WriteLine(item);
        }
        // output => 0 to 99
        Console.ReadKey();
    }
}
