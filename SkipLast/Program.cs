namespace SkipLast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3- skipLast

            IEnumerable<int> collections2 = [1, 2, 3, 4, 5];
            IEnumerable<int> result = collections2.SkipLast(3);
            foreach (var item in result)
            {
                Console.WriteLine(item);  // 1,2
            }

            Console.ReadKey();

        }
    }
}
