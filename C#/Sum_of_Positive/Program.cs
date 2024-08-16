namespace Sum_of_Positive
{
    internal class Program
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
            Console.WriteLine(PositiveSum(new int[] { 1, 2, 3, 4, 5 })); // 15
            Console.WriteLine(PositiveSum(new int[] { })); // 0
            Console.WriteLine(PositiveSum(new int[] { -1, 2, 3, 4, -5 })); // 9
            Console.WriteLine(PositiveSum(new int[] { -1, -2, -3, -4, -5 })); // 0
        }
    }
}
