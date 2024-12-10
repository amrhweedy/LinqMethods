using System.Globalization;

namespace Aggregate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // notion
            // it has a 3 overloads => the return will be put in the first parameter in the second iterator 
            // the y is the next element in the collections

            Console.WriteLine(".................... first overload .....................");
            Console.WriteLine(".........ex1...........");

            //1
            IEnumerable<int> numbers = [1,2 ,3, 4, 5 , 6];
            int result= numbers.Aggregate((x,  y) => x + y);
            Console.WriteLine(result);  // 21


             Console.WriteLine(".........ex2...........");
             //2
             IEnumerable<int> numbers1 = [1, 2, 3, 4, 5, 6];
            string result1 = numbers1.Select(x=> x.ToString()).Aggregate((x, y) => x + y);
            Console.WriteLine(result1);  //123456


            Console.WriteLine("...........ex3.........");

            //3 
            IEnumerable<int> numbers2 = [1, 2, 3, 4, 5, 6];
            string result2 = numbers2.Select(x=> x.ToString()).Aggregate((x, y) => $"{x} , {y}" );
            Console.WriteLine(result2);  //"1 , 2 , 3 , 4 , 5 , 6"

            // here in the first iterator the x is "1" and the y is "2" and the return is "1,2"
            // the second iterator the x is "1,2" and the y is "3" and the return is "1,2,3"
            //the third iterator the x is "1,2,3" and the y is "4" and the return is "1,2,3,4" and so on 



            Console.WriteLine(".................... second overload .....................");

            //1
            IEnumerable<int> numbers3 = [1, 2, 3, 4, 5, 6];
            int result3 = numbers3.Aggregate(10, (x, y) => x + y);
            Console.WriteLine(result3);  // 31

            Console.WriteLine(".................... third overload .....................");
            // we can put in the end of the aggregate method  a function to do something after we aggregated all the values 

            //1 => we need after aggregate the values divide the result by 2

            IEnumerable<int> numbers4 = [1, 2, 3, 4, 5, 6];
            int result4 = numbers4.Aggregate(10, (x, y) => x + y, x => x / 2); // the result of the aggregation is 31 and we divide it by 2 
            Console.WriteLine(result4);  // 15


            Console.WriteLine("........................................");

            // 2- we have a collection of numbers and i need to get the average of this numbers by using aggregate

            IEnumerable<int> numbers5 = [1, 2, 3, 4, 5, 6]; 
            var result5 = numbers.Aggregate(0,(x, y) => x + y , x => (double)x  / numbers.Count());  // the x which in the x=>(double)x /numbers.Count() is the result of the aggregation which is the sum of the numbers 21 then we divide it by the count of the numbers which 6
            Console.WriteLine(result5); //3.5
 

        }
    }
}
