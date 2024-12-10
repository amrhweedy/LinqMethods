namespace Last_LastOrDefault
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> collections = [1, 2, 3 , 4 , 5 , 6];
            var last =  collections.Last();
            Console.WriteLine(last); //6

            var last2 = collections.Last(x=> x < 4);
            Console.WriteLine(last2); // 3


            var lastOrDefault = collections.LastOrDefault();
            Console.WriteLine(lastOrDefault); // 6

            var lastOrDefault2 = collections.LastOrDefault(x => x < 4);
            Console.WriteLine(lastOrDefault2); //3


            Console.WriteLine("..............");

            IEnumerable<int> numbers = [];
            var lastOrDefault3 = numbers.LastOrDefault();
            Console.WriteLine(lastOrDefault3); // 0  , the default

            var last3 = numbers.Last();
            Console.WriteLine(last3); // exception





         }
    }
}
