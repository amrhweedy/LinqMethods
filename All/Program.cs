namespace All
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // all => immediate execution , it returns true if all elements in the collection are match the condition

            IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];
            var result = collection.All(x => x > 2);
            Console.WriteLine(result);  // false
        }
    }
}
