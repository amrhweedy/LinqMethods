namespace Any
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // any => immediate execution and return true or false 
            // it iterates for each item in the collection and with the first element matches the condition it returns true and not complete the iteration
            // here it not iterate for 4,5,6 

            IEnumerable<int> collection = [1, 2, 3, 4, 5, 6];
            var result =  collection.Any(x => x > 2);
            Console.WriteLine(result);  // true


        }
    }
}
