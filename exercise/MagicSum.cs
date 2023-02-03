int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
int numSum = int.Parse(Console.ReadLine());
for (int i = 0; i < inputArray.Length -1; i++)
{
	for (int j = i+1; j < inputArray.Length; j++)
	{
		if (inputArray[i] + inputArray[j] == numSum)
		{
			Console.WriteLine($"{inputArray[i]} {inputArray[j]}");
		}
	}
}