namespace Repeat;

internal class Program
{
    static void Main(string[] args)
    {

        // repeat is differed execution


        IEnumerable<int> numbers = Enumerable.Repeat(1, 10);  // it will repeat the 1  ten times
        foreach (int number in numbers)
        {
            Console.WriteLine(number);  // the output is 1, 1, 1, 1, 1, 1, 1, 1, 1, 1
        }
        Console.ReadKey();
    }
}
