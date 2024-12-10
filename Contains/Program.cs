namespace Contains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // contains => immediate execution , return true or false

            IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];
            var result = collection.Contains(3);
            Console.WriteLine(result);  // true
        }
    }
}
