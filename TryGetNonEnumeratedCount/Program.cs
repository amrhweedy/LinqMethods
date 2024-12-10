namespace TryGetNonEnumeratedCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The TryGetNonEnumeratedCount method in LINQ is used to attempt to get the count of elements in a sequence without enumerating it. This method is particularly useful for checking the size of a collection efficiently when possible, as it avoids the overhead of traversing the entire sequence.
            // it try to get the count of elements in a sequence without enumerating it
            // in the first example i have a list or array in the memory so it has a count property so the TryGetNonEnumeratedCount can access this count directly
            // in the second example the TryGetNonEnumeratedCount will applied on the Deffered execution collection so this new collection does not exist because i do not iterate for it so the TryGetNonEnumeratedCount does not know the count of this collection
            // immediate execution
            // explain in notion

            IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];
            bool  result  = collection.TryGetNonEnumeratedCount(out var count);           
            Console.WriteLine($"{result} - {count}");    // true - 6

            Console.WriteLine("............................");

            IEnumerable<int> collection1 = [1, 2, 3, 4, 5, 6];
            bool result1 = collection.Where(x=>x > 2).TryGetNonEnumeratedCount(out var count1);
            Console.WriteLine($"{result1} - {count1}");   // false - 0



        }
    }
}
