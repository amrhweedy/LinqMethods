namespace SelectMany
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // the explain in the notion
            // ex1
 
            IEnumerable<List<int>> collections = [[1, 2, 3], [4, 5, 6]];
            IEnumerable<int> result = collections.SelectMany(x => x); // result is an one array contains [1,2,3,4,5,6]
            foreach (var item in result)
            {
                Console.WriteLine(item);       // 1 2 3 4 5 6  
            }

            Console.WriteLine("................. ...................");

            //ex2

            IEnumerable<List<int>> collections1 = [[1, 2, 3], [4, 5, 6]];
            IEnumerable<string> result1 = collections1.SelectMany(x => x).Select(x => x.ToString()); // result is an array of strings,first it makes one int array contain [1,2,3,4,5,6] then using select it convert every element to  ["1","2","3","4","5","6"]
            foreach (var item in result1)
            {
                Console.WriteLine(item);      // 1 2 3 4 5 6  but every item is string
            }


            Console.WriteLine("................. ...................");

            //ex3 => i need to make one array contain the characters

            IEnumerable<string> names = ["amr", "ahmed"];
            var chars = names.SelectMany(x => x); // result is an one array contain ["a","m","r","a","h","m","e","d"]
            foreach (var item in chars)
            {
                Console.WriteLine(item);      // a m r a h m e d
            }

            Console.ReadKey();


        }
    }
}
