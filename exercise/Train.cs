int countWagons = int.Parse(Console.ReadLine());
int[] wagons = new int[countWagons];
int countPeople = 0;
for (int i = 0; i < wagons.Length; i++)
{
    int people = int.Parse(Console.ReadLine());
    wagons[i] = people;
    countPeople += people;
}
for (int i = 0; i < wagons.Length; i++)
{
    if (i == wagons.Length - 1)
    {
        Console.WriteLine($"{wagons[i]} ");
    }
    else
    {
        Console.Write($"{wagons[i]} ");
    }
}
Console.WriteLine(countPeople);
