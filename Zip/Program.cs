using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Buffers.Text;
using System;

namespace Zip
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // The Zip method in LINQ is used to combine two sequences or more (collections) into a single sequence by merging corresponding elements based on a specified result selector function.

            IEnumerable<int> collection1 = [1,2,3,4,5];
            IEnumerable<string> collection2 = ["a","b","c","d","e"];
            IEnumerable<string> collections3 = ["#","!","@"];

            IEnumerable<(int, string)> result  = collection1.Zip(collection2); // returns a sequence of tuples 
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Item1} - {item.Item2}");  
            }
            // output =>
            // 1 - a
            // 2 - b
            // 3 - c
            // 4 - d
            // 5 - e


            Console.WriteLine(" ..................... ex2  .....................");
            // i need to group all the 3 collections and determine the shape of the return directly before we print 
            // the zip method the max parameters is 2 

            IEnumerable<string> result2 = collection1
                  .Zip(collection2, (x, y) => new { number = x, letter = y })
                  .Zip(collections3, (temp, z) => $" number : {temp.number} - letter : {temp.letter} - symbol : {z}");

            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }

            // output =>
            // number : 1 - letter : a - symbol : #
            // number : 2 - letter : b - symbol : !
            // number : 3 - letter : c - symbol : @


            Console.WriteLine("............................... ex3 ...............................");

            IEnumerable<(int,string,string)> result3 = collection1.Zip(collection2, collections3);
            foreach(var item in result3)
            {
                Console.WriteLine($" number : {item.Item1} - letter : {item.Item2} - symbol : {item.Item3}");
            }


            // output =>
            // number : 1 - letter : a - symbol : #
            // number : 2 - letter : b - symbol : !
            // number : 3 - letter : c - symbol : @




        }
    }
}
