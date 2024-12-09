namespace partitioning;

internal class Program
{
    static void Main(string[] args)
    {
        // 1- take
        IEnumerable<int> collections = [1, 2, 3, 4, 5];
        IEnumerable<int> takes = collections.Take(3);
        foreach (var item in takes)
        {
            Console.WriteLine(item);  // 1,2,3
        }

        Console.WriteLine("------------------");

        // 2- skip
        IEnumerable<int> collections1 = [1, 2, 3, 4, 5];
        IEnumerable<int> skips = collections1.Skip(3);
        foreach (var item in skips)
        {
            Console.WriteLine(item);  // 4,5
        }

        Console.WriteLine("------------------");

        //3- skiplast

        IEnumerable<int> collections2 = [1, 2, 3, 4, 5];
        IEnumerable<int> skiplast = collections2.SkipLast(3);
        foreach (var item in skiplast)
        {
            Console.WriteLine(item);  // 1,2
        }

        Console.WriteLine("------------------");
        //4- takeLast

        IEnumerable<int> collections3 = [1, 2, 3, 4, 5];
        IEnumerable<int> takeLast = collections3.TakeLast(3);
        foreach (var item in takeLast)
        {
            Console.WriteLine(item);  // 3,4,5
        }

        Console.WriteLine("------------------");

        //5 - takeWhile
        IEnumerable<int> collections4 = [1, 2, 3, 1, 1];
        IEnumerable<int> takeWhile = collections4.TakeWhile(x => x < 2);
        foreach (var item in takeWhile)
        {
            Console.WriteLine(item);  // 1
        }

        Console.WriteLine("------------------");

        //6- skipWhile
        IEnumerable<int> collections5 = [1, 2, 3, 1, 1];
        IEnumerable<int> skipWhile = collections5.SkipWhile(x => x < 2);
        foreach (var item in skipWhile)
        {
            Console.WriteLine(item);  // 2,3,1,1
        }

        Console.ReadKey();
    }
}
