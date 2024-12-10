namespace TakeLast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4- takeLast

            IEnumerable<int> collections3 = [1, 2, 3, 4, 5];
            IEnumerable<int> takeLast = collections3.TakeLast(3);
            foreach (var item in takeLast)
            {
                Console.WriteLine(item);  // 3,4,5
            }
        }
    }
}
