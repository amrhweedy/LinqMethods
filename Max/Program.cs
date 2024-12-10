using System.Xml.Linq;
using System;
using System.Diagnostics.Metrics;

namespace Max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // max => immediate execution
            IEnumerable<int> collection = [1,2,3,4,5];
            int maxNumber = collection.Max();
            Console.WriteLine(maxNumber); // 5

            Console.WriteLine("...................");
            //ex2
            IEnumerable<int> collection1 = [1, 2, 3, 4, 5];
            int maxNumber1 = collection.Max(x=> x * -1);
            Console.WriteLine(maxNumber1);  // -1

            //     Behind - the - Scenes Operations
            //Step 1: Iterating Over the Sequence
            //The Max method internally enumerates the collection(IEnumerable<int> collection1).
            //For each element in the collection, the lambda function(x => x* -1) is executed.
            //Step 2: Applying the Transformation
            //The transformed values(-1, -2, -3, -4, -5) are stored in memory temporarily during the calculation.

           //Step 3: Comparing Values
           //The Max method keeps track of the current largest value while iterating:
           //Initially: Largest = -1(from the first element).
           //Compare - 2 with - 1: Largest remains -1.
           //Compare - 3 with - 1: Largest remains -1.
           //Similarly for -4 and - 5.
           //Step 4: Final Result
           //After iterating through all elements, the maximum transformed value(-1) is ret





        }
    }
}
