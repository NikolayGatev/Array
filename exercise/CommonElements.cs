string[] array1 = Console.ReadLine().Split(' ');
string[] array2 = Console.ReadLine().Split();

var intersect = array2.Intersect(array1);
foreach (string value in intersect)
{
    Console.Write($"{value} ");
}