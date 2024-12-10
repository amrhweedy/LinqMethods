namespace Cast
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 4- cast => convert from one type to another 
            //Cast<int> will try to cast each element from object to int.
            //If any element cannot be converted to the target type (int), an invalid cast exception (InvalidCastException) would be thrown. For example, if the collection contained a string or a different non-integer type, this would cause an exception.
 
            IEnumerable<object> collections = [1, 2, 3, 4, 5];
            IEnumerable<int> result = collections.Cast<int>();
            foreach (var item in result)   // every item here is int
            {
                Console.WriteLine(item); // 1 2 3 4 5
            }

        }
    }
}
