int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
int countRotate = int.Parse(Console.ReadLine());
int temp;
for (int i = 0; i < countRotate; i++)
{
	temp = array[0];
	for (int j = 0; j < array.Length - 1; j++)
	{
		array[j] = array[j + 1];		
	}

    array[array.Length - 1] = temp;   
}
Console.WriteLine(String.Join(" ", array));