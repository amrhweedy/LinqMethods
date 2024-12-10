namespace FirstOrDefault
{
    internal class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<int> numbers2 = [];
            int first2 = numbers2.FirstOrDefault(x => x > 5); 
            Console.WriteLine(first2);  // 0

            // if there is any element match the condition it will return the default value here is 0
        }
    }
}
