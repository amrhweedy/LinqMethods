namespace Select_SelectWithIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1- select 

            IEnumerable<int> collections = [1, 2, 3, 4, 5];
            IEnumerable<int> result = collections.Select(x => x * x);
            foreach (var item in result)
            {
                Console.WriteLine(item); // 1 4 9 16 25
            }

            Console.WriteLine("................");

            //2 - select with index
            IEnumerable<int> collections2 = [1, 2, 3, 4, 5];
            IEnumerable<string> result2 = collections2.Select((x, index) => $"{index} - {x}");
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
