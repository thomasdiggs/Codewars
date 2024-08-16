namespace Even_or_Odd
{
    internal class Program
    {
        public static string EvenOrOdd(int number)
        {
            return number % 2 == 0 ? "Even" : "Odd";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(EvenOrOdd(2)); // Even
            Console.WriteLine(EvenOrOdd(0)); // Even
            Console.WriteLine(EvenOrOdd(7)); // Odd
            Console.WriteLine(EvenOrOdd(1)); // Odd
        }
    }
}
