namespace Join;

record Person(int Id , string Name , int Age);
record Product(int ProductId , string ProductName, int PersonId);

internal class Program
{
    static void Main(string[] args)
    {
        // The Join method in LINQ is used to combine two collections (or sequences) based on matching keys.
        // It performs an inner join, meaning it only includes elements from both collections where the keys match.
        // It's commonly used for relational-style data operations, similar to SQL joins.
        // notion

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

        var result =  persons.Join(     // persons => outer collection
                   products,             // products => inner collection
                   person => person.Id,   //  key from the outer collection
                   product => product.PersonId,  // key from the inner collection
                   (person, product) => $" {person.Name} bought  {product.ProductName}"   //result selector
                   );

       foreach(var item in result)
        {
            Console.WriteLine(item);
        }

         // output =>

         // amr bought  shoes
         // amr bought  pants
         // mohamed bought  shirt

     }

  }

