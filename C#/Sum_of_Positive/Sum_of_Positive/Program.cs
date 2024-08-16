namespace Sum_of_Positive;

class Program
{
    public static int PositiveSum(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            if (num > 0)
            {
                sum += num;
            }
        }
        return sum;
    }
    static void Main(string[] args)
    {
        Console.WriteLine(PositiveSum(new int[] { 1, 2, 3, 4, 5 }));
        Console.WriteLine(PositiveSum(new int[] { }));
        Console.WriteLine(PositiveSum(new int[] { -1, 2, 3, 4, -5 }));
        Console.WriteLine(PositiveSum(new int[] { -1, -2, -3, -4, -5 }));
    }
}
