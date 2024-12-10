namespace Take
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<int> collections = [1, 2, 3, 4, 5];
            IEnumerable<int> takes = collections.Take(3);
            foreach (var item in takes)
            {
                Console.WriteLine(item);  // 1,2,3
            }

            Console.ReadKey();
        }
    }
}
