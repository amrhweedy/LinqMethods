namespace Sum
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // immediate execution

            IEnumerable<int> numbers = [1, 2, 3];
            int sum = numbers.Sum();
            Console.WriteLine(sum);  // 6

            // note => sum works only with the IEnumerable<int> or IEnumerable<double>
         }
    }
}
