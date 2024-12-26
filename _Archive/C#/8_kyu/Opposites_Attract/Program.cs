namespace Opposites_Attract
{
    internal class Program
    {
        public static bool lovefunc(int flower1, int flower2)
        {
            return flower1 % 2 != flower2 % 2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(lovefunc(1, 4)); // True
            Console.WriteLine(lovefunc(2, 2)); // False
            Console.WriteLine(lovefunc(0, 1)); // True
            Console.WriteLine(lovefunc(0, 0)); // False
        }
    }
}
