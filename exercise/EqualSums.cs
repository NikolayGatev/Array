decimal[] array = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
decimal sumLeft = 0;
decimal sumRight = 0;
int countElementHit = 0;
for (int i = 0; i < array.Length; i++)
{
	if (i < array.Length -1)
	{
		for (int j = i + 1; j < array.Length; j++)
		{
			sumRight += array[j];
		}
	}
	if (sumRight == sumLeft)
	{
		Console.WriteLine(i);
		countElementHit++;
	}
	sumRight = 0;
	sumLeft += array[i];
}
if (countElementHit == 0)
{
	Console.WriteLine("no");
}
