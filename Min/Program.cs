namespace Min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // min => immediate execution
            IEnumerable<int> collection = [1, 2, 3, 4, 5];
            int minNumber = collection.Min();
            Console.WriteLine(minNumber); // 1


             IEnumerable<int> collection2 = [1, 2, 3, 4, 5];
            int minNumber2 = collection.Min(x=> x * -1);
            Console.WriteLine(minNumber2); // -5


        }
    }
}
