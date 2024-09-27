namespace Is_n_divisible_by_x_any_y
{
    internal class Program
    {
        public static bool IsDivisible(int n, int x, int y)
        {
            if (n % x == 0 && n % y == 0)
            {
                return true;
            }
            return false;
        }

        // Also could have done this (less readable in my opinion)
        // public static bool IsDivisible(int n, int x, int y) => n % x == 0 && n % y == 0;

        static void Main(string[] args)
        {
            Console.WriteLine(IsDivisible(12, 4, 3));   // True
            Console.WriteLine(IsDivisible(12, 5, 3));   // False
        }
    }
}