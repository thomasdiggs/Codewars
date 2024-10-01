namespace Find_the_smallest_integer_in_the_array
{
    internal class Program
    {
        public static int FindSmallestInt(int[] args)
        {
            int smallest = args[0];
            for (int i = 1; i < args.Length; i++)
            {
                if (args[i] < smallest)
                {
                    smallest = args[i];
                }
            }
            return smallest;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(FindSmallestInt(new int[] { 34, 15, 88, 2 }));        // 2
            Console.WriteLine(FindSmallestInt(new int[] { 34, -345, -1, 100 }));    // -345
        }
    }
}
