namespace First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // immediate execution
            IEnumerable<int> numbers= [1,2,3,4,5,6,7,8,9,10];
            int first = numbers.First();
            Console.WriteLine(first);   // 1


            IEnumerable<int> numbers1 = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            int first1 = numbers.First(x=> x > 5);
            Console.WriteLine(first1);  // 6




            IEnumerable<int> numbers2= [];
            int first2 = numbers2.First(x => x > 5); // throws exception because there is no any element match the condition
            Console.WriteLine(first2); 





        }
    }
}
