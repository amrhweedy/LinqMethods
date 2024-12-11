namespace SequenceEqual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The SequenceEqual method in LINQ is used to determine whether two sequences(collections) are equal by comparing their elements in the same order using the default equality comparer or a specified comparer.
            // return bool
            // notion => contain example with custom comparer

            IEnumerable<int> collection1 = [1, 2, 3];
            IEnumerable<int> collection2 = [1, 2, 3];
            IEnumerable<int> collection3 = [1, 2, 3 , 4];
            Console.WriteLine(collection1.SequenceEqual(collection2));  // true
            Console.WriteLine(collection1.SequenceEqual(collection3));  // false


         }
    }
}
