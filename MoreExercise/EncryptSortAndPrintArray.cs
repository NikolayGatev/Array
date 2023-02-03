using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks.Dataflow;

int countsStrings = int.Parse(Console.ReadLine());
int[] code = new int[countsStrings];
for (int i = 0; i < countsStrings; i++)
{
    int sum = 0;
    char[] newString = Console.ReadLine().ToCharArray();
    foreach (var item in newString)
    {
        if (item == 'a' || item == 'A' 
            || item == 'e' || item == 'E' 
            || item == 'i' || item == 'I' 
            || item == 'o' || item == 'O' 
            || item == 'u' || item == 'U')
        {
            sum += item * newString.Length;
        }
        else
        {
            sum += item / newString.Length;
        }
    }

    code[i] = sum;
}
Array.Sort(code);
foreach (var item in code)
{
    Console.WriteLine(item);
}
