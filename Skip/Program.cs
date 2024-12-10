namespace Skip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2- skip
            IEnumerable<int> collections1 = [1, 2, 3, 4, 5];
            IEnumerable<int> skips = collections1.Skip(3);
            foreach (var item in skips)
            {
                Console.WriteLine(item);  // 4,5
            }
            Console.ReadKey();
        }
    }
}
