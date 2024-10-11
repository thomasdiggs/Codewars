
namespace Simple_multiplication
{
    internal class Program
    {
        public static int Multiply(int x)
        {
            return x % 2 == 0 ? x * 8 : x * 9;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(5));  // 45
        }
    }
}
