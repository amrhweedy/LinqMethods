namespace SkipWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6- skipWhile

            IEnumerable<int> collections = [1, 2, 3, 1, 1];
            IEnumerable<int> result = collections.SkipWhile(x => x < 2);
            foreach (var item in result)
            {
                Console.WriteLine(item);  // 2,3,1,1
            }

        }
    }
}
