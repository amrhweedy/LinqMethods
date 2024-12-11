
namespace Distinct;

internal class Program
{
    static void Main(string[] args)
    {
        // notion
        //The Distinct LINQ method removes duplicate elements from a sequence and returns only unique elements. It is used to filter a collection so that only distinct values remain.
        // differed execution , it returns a new collection
        // ex1 => simple 

        //1. **Default Equality Comparer**:
        //For primitive types like `int`, `string`, etc., the `Distinct` method uses the default equality comparer, which compares the actual values.

        IEnumerable<int> numbers = [1, 2, 3, 2];
        var result = numbers.Distinct();

        foreach (var number in result)
        {
            Console.WriteLine(number); // 1 , 2 , 3
        }


        //ex2 => using custom comparer (notion)

        Console.WriteLine("........ using custom comparer ...........");

        Console.ReadKey();
    }
}




