namespace Append
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // append => make a new collection and add the item in the end of this collection

            IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];
            IEnumerable<int> result = collection.Append(7);   //[1, 2, 3, 4, 5, 6, 7]
            foreach (var item in result)
            {
                Console.WriteLine(item);   // 1, 2, 3, 4, 5, 6, 7
            }
         }
    }
}
