namespace Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // count => immediate execution

            IEnumerable<int> collection = [1,2,3,4,5 ,6];
            int count = collection.Count();
            Console.WriteLine(count);   // 6


            Console.WriteLine("...........");

            IEnumerable<int> collection1 = [1, 2, 3, 4, 5, 6];
            int count1 = collection.Where(x=> x >2).Count();  // The Count method enumerates the filtered sequence produced by Where and counts how many elements it contains.
            Console.WriteLine(count1);   // 4


        }
    }
}
