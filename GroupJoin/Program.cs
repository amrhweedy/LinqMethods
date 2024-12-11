using System;
using System.Buffers.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;
namespace GroupJoin;
//The GroupJoin method in LINQ is used to produce a collection of groups where each group consists of elements from two collections that match based on a key.It's like a SQL LEFT OUTER JOIN, but the results are grouped.
// first it makes normal join like join method then make a groups based on this join based on the key on the outer collection
// notion
record Person(int Id, string Name, int Age);
record Product(int ProductId, string ProductName, int PersonId);
internal class Program
{
    static void Main(string[] args)
    {
        IEnumerable<Person> persons = new List<Person>()
        {
            new(1,"amr",20),
            new(2,"mohamed",30),
            new(3,"ali",40),
        };

        IEnumerable<Product> products = new List<Product>()
    {
        new(1,"shoes",1),
        new(2,"pants",1),
        new(3, "shirt" , 2)

    };

        var result = persons.GroupJoin(     // persons => outer collection
                   products,             // products => inner collection
                   person => person.Id,   //  key from the outer collection
                   product => product.PersonId,  // key from the inner collection
                   (person, products) => new { PersonName = person.Name , products = products.Select(p=> p.ProductName)}  //result selector
                   );

        // here the products are IEnumerable<product> because the one person like amr have many products so we make a group the key is amr and the value are the products which bought them

        foreach (var item in result)
        {
            Console.WriteLine($"key : {item.PersonName}");
            foreach(var product in item.products)
            {
                Console.WriteLine($"       product : {product}");
            }
         }

        // output =>
        // key : amr
        //       product : shoes
        //       product : pants
        // key : mohamed
        //       product : shirt
        // key : ali

    }
}
