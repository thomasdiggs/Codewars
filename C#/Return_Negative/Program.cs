namespace Return_Negative
{
    internal class Program
    {
        public static int MakeNegative(int number)
        {
            return number > 0 ? number - (number * 2) : number;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(MakeNegative(42)); // -42
            Console.WriteLine(MakeNegative(-42)); // -42
            Console.WriteLine(MakeNegative(0)); // 0
        }
    }
}
