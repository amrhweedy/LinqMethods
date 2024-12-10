using System.Globalization;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata;

namespace DefaultOrEmpty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DefaultOrEmpty is used to return a default value if the sequence is empty
            //The DefaultIfEmpty method in LINQ is used to handle cases where a sequence is empty.If the sequence is empty, it will provide a default value in place of the empty sequence.If the sequence is not empty, it simply returns the original sequence.
            // notion

            IEnumerable<int> numbers = [1,2 , 3];
            var result = numbers.DefaultIfEmpty();
            foreach (var item in result)
            {
                Console.WriteLine(item);  // 1,2,3   => return the original sequence
            }

            Console.WriteLine(".................");

            IEnumerable<int> numbers2 = Enumerable.Empty<int>();
            var result2 = numbers2.DefaultIfEmpty();
            foreach (var item in result2)
            {
                Console.WriteLine(item);  // 0 => return the default
            }
         }
    }
}
