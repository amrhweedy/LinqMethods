namespace Empty;

internal class Program
{
    static void Main(string[] args)
    {

        //The Enumerable.Empty<T>() method in LINQ is a static method that creates an empty sequence of a specified type. This sequence contains no elements and is represented as an IEnumerable<T>.
        // differed execution so this numbers are not stored in the memory until i iterate on it

        IEnumerable<int> numbers = Enumerable.Empty<int>();
    }
}
