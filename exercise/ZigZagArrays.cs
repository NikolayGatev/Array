int n = int.Parse(Console.ReadLine());
int[] array1 = new int[n];
int[] array2 = new int[n];
for (int i = 1; i <= n; i++)
{
    int[] curentArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
    if (i % 2 == 0)
    {
        array2[i - 1] = curentArray[0];
        array1[i -1] = curentArray[1];
    }
    else
    {
        array1[i - 1] = curentArray[0];
        array2[i - 1] = curentArray[1];
    }
}
for (int i = 0; i < array1.Length; i++)
{
    if (i != array1.Length - 1)
    {
        Console.Write($"{array1[i]} ");
    }
    else
    {
        Console.WriteLine(array1[i]);
    }
}
for (int i = 0; i < array2.Length; i++)
{
    if (i != array2.Length - 1)
    {
        Console.Write($"{array2[i]} ");
    }
    else
    {
        Console.WriteLine(array2[i]);
    }
}