int rows = int.Parse(Console.ReadLine());
int y = 2;
Console.WriteLine(1);
int[] previous = new int [y]; 
for (int i = 2; i <= rows; i++)
{
    int[] next = new int[i];
    next[0] = 1;
    next[next.Length - 1] = 1;
    for (int j = 1; j < next.Length - 1; j++)
    {
        if (previous.Length > 1)
        {
            next[j] = previous[j - 1] + previous[j];
        }
    }
    Console.WriteLine(String.Join(' ',next));
    y = i;
    previous = new int[y];

    Array.Copy(next, previous, next.Length);       
}