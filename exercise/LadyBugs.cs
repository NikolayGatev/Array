int n = int.Parse(Console.ReadLine());
int[] fieldSize = new int[n];
Array.Fill<int>(fieldSize, 0);
string[] indexBug = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int[] startPozitionLadybug = new int[indexBug.Length];
int count = -1;
foreach (var value in indexBug)
{
    count++;
    int curentBug;
    bool success = int.TryParse(value, out curentBug);
    if (success)
        startPozitionLadybug[count] = curentBug;
    else
        startPozitionLadybug[count] = -1;
}
for (int i = 0; i < startPozitionLadybug.Length; i++)
{
    if (startPozitionLadybug[i] < fieldSize.Length && startPozitionLadybug[i] >= 0)
    {
        fieldSize[startPozitionLadybug[i]] = 1;
    }
}
string comand = Console.ReadLine();
string[] comandArray = new string[2];
int fromPlaceFly;
int toPlaceFly;
while (comand != "end")
{
    comandArray = comand.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    fromPlaceFly = int.Parse(comandArray[0]);
    toPlaceFly = int.Parse(comandArray[2]);
    if ((comandArray[1] == "right" && fromPlaceFly > toPlaceFly) || (comandArray[1] == "left" && fromPlaceFly < toPlaceFly))
    {
        fieldSize[fromPlaceFly] = 0;
    }
    if ((comandArray[1] == "right") && (fieldSize[fromPlaceFly] == 1))
    {
        for (int i = toPlaceFly; i < fieldSize.Length; i++)
        {
            if (fieldSize[i] == 0)
            {
                fieldSize[i] = 1;
                fieldSize[fromPlaceFly] = 0;
                break;
            }
            else if (i == (fieldSize.Length - 1))
            {
                fieldSize[fromPlaceFly] = 0;
            }
        }
    }
    else if ((comandArray[1] == "left") && (fieldSize[fromPlaceFly] == 1))
    {
        for (int i = toPlaceFly; i >= 0; i--)
        {
            if (fieldSize[i] == 0)
            {
                fieldSize[i] = 1;
                fieldSize[fromPlaceFly] = 0;
                break;
            }
            else if (i == 0)
            {
                fieldSize[fromPlaceFly] = 0;
            }
        }
    }
    comand = Console.ReadLine();
}
