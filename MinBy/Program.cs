using System;

namespace MinBy
{
    internal class Program
    {
        record Person(string Name, int Age);

        static void Main(string[] args)
        {

            // MinBy gives you the element that produced the min value. 

            IEnumerable<int> collection = [1, 2, 3, 4, 5];
            int element = collection.MinBy(x => x * -1);
            Console.WriteLine(element);  // 5

            // the result is  5 because the element 5 produced the min value (5 * -1 = -5)


            Console.WriteLine(".............................");
            //ex2


            IEnumerable<Person> persons = new List<Person>()
            {
                new Person("amr" , 20),
                new Person("mohamed" , 25),
                new Person("ahmed" , 30)
            };


            Person? minPerson = persons.MinBy(x => x.Age);  // returns the element (person) that has a min age

            Console.WriteLine($"the min person is {minPerson.Name} , age :{minPerson.Age} ");
        }
    }
}
