namespace ElementAt_ElementAtOrDefault
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ElementAt and ElementAtOrDefault are used to get the element at a specific index in a collection.
            // ElementAt is used to get the element at a specific index in a collection and throws an exception if the index is out of range.
            // ElementAtOrDefault is used to get the element at a specific index in a collection and returns the default value if the index is out of range.

            IEnumerable<int> numbers = [1, 2, 3];
            int index  = numbers.ElementAt(2);
            Console.WriteLine(index);  // Output: 3

            int index2 = numbers.ElementAtOrDefault(2);
            Console.WriteLine(index2);  // Output: 3

            int index3 = numbers.ElementAtOrDefault(15);
            Console.WriteLine(index3);  // Output: 0 , the default value

            int index4 = numbers.ElementAt(15);
            Console.WriteLine(index4);  // Output: IndexOutOfRangeException


        }
    }
}
