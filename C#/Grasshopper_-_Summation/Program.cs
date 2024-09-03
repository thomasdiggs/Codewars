namespace Grasshopper___Summation
{
    internal class Program
    {
        public static int Summation(int num)
        {
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum += i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Summation(1));    // 1
            Console.WriteLine(Summation(8));    // 36
            Console.WriteLine(Summation(22));   // 253
        }
    }
}