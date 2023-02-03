internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(FibonacciRecursive(n));
    }
    static int FibonacciRecursive(int n)
    {
        if (n <= 2)
        {
            return 1;
        }
        else
        {
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }
    }
}
