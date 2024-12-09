namespace OfType;

internal class Program
{
    static void Main(string[] args)
    {
        IEnumerable<object> collections = [1, 2, 3, 4, 5, "amr", "ali"];
        IEnumerable<int> numbers = collections.OfType<int>();  // create a new collection because the OfType returns iEnumerable so it is a differed execution, it does not modify the original collections
        foreach (var item in numbers)
        {
            Console.WriteLine(item);  // 1,2,3,4,5
        }

        IEnumerable<string> names = collections.OfType<string>();   // create a new collection because the OfType returns iEnumerable so it is a differed execution, it does not modify the original collections
        foreach (var item in names)
        {
            Console.WriteLine(item); // amr,ali
        }

        Console.ReadKey();
    }
}
