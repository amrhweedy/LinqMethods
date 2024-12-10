using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

namespace MaxBy
{
    record Person(string Name , int Age);
    internal class Program
    {
        static void Main(string[] args)
        {

            // MaxBy gives you the element that produced the maximum value. (notion)

            IEnumerable<int> collection = [1, 2, 3, 4, 5];
            int maxNumber1 = collection.MaxBy(x => x * -1);
            Console.WriteLine(maxNumber1);  // 1

            // the result is 1 because the element 1 produced the maximum value (1 * -1 = -1)


            Console.WriteLine(".............................");
            //ex2


            IEnumerable<Person> persons  = new List<Person>()
            {
                new Person("amr" , 20),
                new Person("mohamed" , 25),
                new Person("ahmed" , 30)
            };


            Person? bigPerson = persons.MaxBy(x=>x.Age);  // returns the element (person) that has a big age

            Console.WriteLine($"the big person is {bigPerson.Name} , age :{bigPerson.Age} ");
            

      

            

        }

    }
}
