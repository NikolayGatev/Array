int[] inputIntegers = Console.ReadLine()
                      .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                      .Select(int.Parse)
                      .ToArray();
int[] foldIntegers = new int[inputIntegers.Length / 2];
int counter = 0;
for (int i = (inputIntegers.Length / 4) -1; i >= 0; i--)
{
    foldIntegers[counter] = inputIntegers[i];
    counter++;
}
counter = foldIntegers.Length / 2;
for (int i = inputIntegers.Length - 1; i >= inputIntegers.Length - (inputIntegers.Length / 4); i--)
{
    foldIntegers[counter] = inputIntegers[i];
    counter++;
}
int[] inputIntegersSecond = new int[inputIntegers.Length / 2];
Array.Copy(inputIntegers, (inputIntegers.Length / 4), inputIntegersSecond, 0, inputIntegersSecond.Length);
int[] sum = new int[foldIntegers.Length];
for (int i = 0; i < foldIntegers.Length; i++)
{
    sum[i] = foldIntegers[i] + inputIntegersSecond[i];
}
Console.WriteLine(String.Join(' ', sum));