
namespace Calculate_average
{
    internal class Program
    {
        public static double FindAverage(double[] array) => array.Length == 0 ? 0 : array.Average();

        static void Main(string[] args)
        {
            double[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine(FindAverage(array));  // 3
        }
    }
}
