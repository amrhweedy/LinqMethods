using System.Linq.Expressions;

namespace Single_SingleOrDefault
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // single and SingleOrDefault will throw exception if there is more than one element match the conditions
            // single will throw exception if there is no element
            // SingleOrDefault will return default value if there is no element

            IEnumerable<int> numbers = [1, 2, 3, 4, 5];
            int single = numbers.Single(); // System.InvalidOperationException: 'Sequence contains more than one element'
            int singleOrDefault = numbers.SingleOrDefault();  //System.InvalidOperationException: 'Sequence contains more than one element'


            IEnumerable<int> numbers1 = [1, 2, 2, 4, 5];
            int single1 = numbers1.Single(x => x == 2); // System.InvalidOperationException: 'Sequence contains more than one element'
            int singleOrDefault1 = numbers1.SingleOrDefault(x => x == 2);  //System.InvalidOperationException: 'Sequence contains more than one element'


            IEnumerable<int> numbers3 = [];
            int single3 = numbers3.Single(); //System.InvalidOperationException: 'Sequence contains no elements'
            int singleOrDefault3 = numbers3.SingleOrDefault();  // null not exception



        }
    }
}
