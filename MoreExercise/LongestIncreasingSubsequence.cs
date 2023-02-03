int[] nums = Console.ReadLine()
             .Split(' ', StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToArray();
int[] len = new int[nums.Length];
int[] prev = new int[nums.Length];
int maxLength = 1;
int prevIndex = -1;
for (int e = 0; e < nums.Length; e++)
{
    len[e] = 1;
    prev[e] = -1;
    for (int i = 0; i < e; i++)
    {
        if (nums[e] > nums[i] && len[i] >= len[e])
        {
            len[e] = len[i] + 1;
            prev[e] = i;
        }
    }
    if (len[e] > maxLength)
    {
        maxLength = len[e];
        prevIndex = e;
    }
}
int[] output = new int[maxLength];
for (int i = 0; i < output.Length; i++)
{
    output[i] = nums[prevIndex];
    prevIndex = prev[prevIndex];
}
Array.Reverse(output);
Console.WriteLine(String.Join(' ', output));
