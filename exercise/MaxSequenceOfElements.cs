int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
int curentSequence = 1;
int curentNumSequence;
int numMaxSequence = array[0];
int maxSequence = 1;
for (int i = 0; i < array.Length; i++)
{
    curentNumSequence = array[i];
	for (int j = i + 1; j < array.Length; j++)
	{
		int a = array[j];
		if (array[j] == curentNumSequence)
		{
			curentSequence++;
		}
		else
		{
			break;
		}
		if (maxSequence < curentSequence)
		{
			maxSequence = curentSequence;
			numMaxSequence = curentNumSequence;
		}
    }
    curentSequence = 1;
}
for (int i = 0; i < maxSequence; i++)
{
	Console.Write($"{numMaxSequence} ");
}