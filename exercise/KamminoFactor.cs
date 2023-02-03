byte n = byte.Parse(Console.ReadLine());
string inputAll = "";
string curentInput = Console.ReadLine();
int countInput = 0;
while (curentInput != "Clone them!")
{
    countInput++;
    if (countInput == 1)
    {
        inputAll = curentInput;
    }
    else
    {
        inputAll = ($"{inputAll} {curentInput}");
    }
    curentInput = Console.ReadLine();
}
string[] allLinesInput = inputAll.Split(' ', StringSplitOptions.RemoveEmptyEntries);
int[] oneLine = new int[n];
int[] arrayDNA = new int[n];
int sumArrayDNA = 0;
int firstLeftSymbolArrayDNAInSeq = -1;
int neighborsArrayDNA = 0;
int numberOfLineDNA = 0;
for (int i = 0; i < countInput; i++)
{
    oneLine = allLinesInput[i].Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    int neighbors = 0;
    int curentFirstLeftSym = -1;
    Boolean firstLeft = false;
    int firstLeftSymbolOneLineInSeq = -1;
    int neighborsOneLine = 0;
    int sumOneLine = 0;
    for (int j = 0; j < n; j++)
    {
        sumOneLine +=oneLine[j];
        if (oneLine[j] == 1 && firstLeft == false)
        {
           curentFirstLeftSym = j;
           firstLeft = true;
           neighbors++;

        }
        else if (oneLine[j] == 1 && firstLeft == true)
        {
            neighbors++;
        }
        else
        {
            if (neighbors > neighborsOneLine)
            {
                neighborsOneLine = neighbors;
                neighbors = 0;
                firstLeftSymbolOneLineInSeq = curentFirstLeftSym;
            }
            else
            {
                neighbors = 0;
            }
            firstLeft = false;
        }
        if (j == n - 1 && neighbors > neighborsOneLine)
        {
            neighborsOneLine = neighbors;
            neighbors = 0;
            firstLeftSymbolOneLineInSeq = curentFirstLeftSym;
        }

    }
    if ((neighborsOneLine > neighborsArrayDNA) || 
        (neighborsOneLine == neighborsArrayDNA && firstLeftSymbolOneLineInSeq < firstLeftSymbolArrayDNAInSeq) || 
        (neighborsOneLine == neighborsArrayDNA && firstLeftSymbolOneLineInSeq == firstLeftSymbolArrayDNAInSeq && sumOneLine > sumArrayDNA))
    {
        arrayDNA = oneLine;
        numberOfLineDNA = i;
        sumArrayDNA = sumOneLine;
        firstLeftSymbolArrayDNAInSeq = firstLeftSymbolOneLineInSeq;
        neighborsArrayDNA = neighborsOneLine;
    }
    sumOneLine = 0;
}
Console.WriteLine($"Best DNA sample {numberOfLineDNA + 1} with sum: {sumArrayDNA}.");
    Console.Write(String.Join(' ', arrayDNA));
