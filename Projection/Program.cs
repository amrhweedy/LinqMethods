// See https://aka.ms/new-console-template for more information
 

//1- select 

IEnumerable<int> collections = [1,2 ,3 , 4 , 5];
IEnumerable<int> result = collections.Select(x => x * x);
foreach (var item in result)
{
    Console.WriteLine(item); // 1 4 9 16 25
}

Console.WriteLine("................");

//2 - select with index
IEnumerable<int> collections2 = [1,2 ,3 , 4 , 5];
IEnumerable<string> result2 = collections2.Select((x , index) => $"{index} - {x}");
foreach (var item in result2)
{
    Console.WriteLine(item); 
}



// 3 - select many => the explain in the notion
Console.WriteLine(".... select many ....");

IEnumerable<List<int>> collections3 = [[1, 2, 3], [4, 5, 6]];
IEnumerable<int> result3 = collections3.SelectMany(x => x);
foreach (var item in result3)
{
    Console.WriteLine(item);       // 1 2 3 4 5 6  
}


Console.WriteLine(".... select many 2 ....");


// another example  for select many
IEnumerable<List<int>> collections4 = [[1, 2, 3], [4, 5, 6]];
IEnumerable<string> result4 = collections4.SelectMany(x => x).Select(x=> x.ToString());
foreach (var item in result4)
{
    Console.WriteLine(item);      // 1 2 3 4 5 6  but every item is string
}


// 4- cast => convert from one type to another 
//Cast<int> will try to cast each element from object to int.
//If any element cannot be converted to the target type (int), an invalid cast exception (InvalidCastException) would be thrown. For example, if the collection contained a string or a different non-integer type, this would cause an exception.
Console.WriteLine(".... cast ....");

IEnumerable<object> collections5 = [1,2 ,3 , 4 , 5];
 IEnumerable<int> result5 = collections5.Cast<int>();
 foreach (var item in result5)
 {
    Console.WriteLine(item); // 1 2 3 4 5
 }











