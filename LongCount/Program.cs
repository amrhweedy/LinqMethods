namespace LongCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // the difference between Count and LongCount => LongCount returns long
            IEnumerable<int> numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            long count = numbers.LongCount();
            Console.WriteLine(count);   // 10
         }
    }
}
