using System.Collections.Generic;
using System.Xml.Linq;
namespace Concat;

internal class Program
{
   // The Concat method in LINQ is used to combine two collections into one sequence.
   // It appends the elements of the second collection to the first collection, effectively creating a new sequence containing all the elements from both collections.
   // The key aspect is that Concat does not remove duplicates, meaning it simply adds the elements of the second collection to the first as they are.
    static void Main(string[] args)
    {
        IEnumerable<int> collection1 = [1,2,3];
        IEnumerable<int> collection2 = [2,3,4];
        
        IEnumerable<int> result = collection1.Concat(collection2);
        foreach (var item in result)
        {
            Console.WriteLine(item);   // Output: 1 2 3 2 3 4    => not remove the duplicates unlike the union
        }
     }
}
