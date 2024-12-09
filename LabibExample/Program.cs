namespace LabibExample;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        IEnumerable<int> result = list.Where(i => i % 2 == 0);  //where is a deferred execution method

        list.Remove(2);
        list.AddRange(new List<int>() { 11, 12, 13, 14, 15 });

        foreach (var item in result)
        {
            Console.WriteLine(item);     // result => 4,6,8,10,12,14   , it removes already the 2 and add the 11,12,13,14,15.
        }

        Console.ReadKey();

    }
}
