namespace TakeWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //5 - takeWhile
            IEnumerable<int> collections = [1, 2, 3, 1, 1];
            IEnumerable<int> result = collections.TakeWhile(x => x < 2);
            foreach (var item in result)
            {
                Console.WriteLine(item);  // 1
            }

            Console.ReadKey();
        }
    }
}
