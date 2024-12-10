namespace Chunk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // split a sequence into smaller chunks (batches) of a specified size. It creates a sequence of arrays, where each array contains a "chunk" of elements from the original sequence.
            // size: The maximum number of elements in each chunk. Must be greater than 0; otherwise, an exception is thrown.
            // note => the chunk is an opposite of SelectMany 


            //ex1

            IEnumerable<int> collections = [1, 2, 3, 4, 5, 6];
            IEnumerable<int[]> result = collections.Chunk(3);  // the result here is  a collection of 2 arrays  [[1, 2, 3], [4, 5, 6]] , i determine the size for every array or chunk is 3 it means every chunk must contain 3 element
            foreach (var item in result)   
            {
                Console.WriteLine(item);  // output =>  System.Int32[]  ,  System.Int32[]

            }

            Console.WriteLine(".....................................");

            //ex2
            IEnumerable<int> collections1 = [1, 2, 3, 4, 5, 6];
            IEnumerable<int[]> result1 = collections1.Chunk(3);
            foreach (var item in result1)
            {
                Console.WriteLine($" chunk:{string.Join("," , item)}");    
            }

            // output =>
            // chunk:1,2,3
            // chunk:4,5,6

            Console.WriteLine("......................................");

            //ex3 => using SelectMany to return the original sequence after making chunk
            IEnumerable<int> collections2 = [1, 2, 3, 4, 5, 6];
            IEnumerable<int[]> result2 = collections2.Chunk(3);  // [[1, 2, 3], [4, 5, 6]]
            IEnumerable<int> selectedManyResult = result2.SelectMany(x=>x);   // [1, 2, 3, 4, 5, 6]
            foreach (var item in selectedManyResult)
            {
                Console.WriteLine(item);    // output => 1,2,3,4,5,6
             }
            


        }
    }
}
