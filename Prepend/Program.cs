namespace Prepend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prepend => make a new collection and add the item in the first of this collection

            IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];
            IEnumerable<int> result = collection.Prepend(0); // [0,1,2,3,4,5,6]
            foreach (var item in result)
            {
                Console.WriteLine(item);   // 0 , 1, 2, 3, 4, 5, 6
            }
        }
    }
}
