namespace Average
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = [ 1, 2, 3, 4, 5  , 6];
            var average = numbers.Average();
            Console.WriteLine(average);   //3.5
         }
    }
}
