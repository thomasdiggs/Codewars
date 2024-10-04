
namespace Sum_Arrays
{
    internal class Program
    {
        public static double SumArray(double[] array)
        {
            double sum = 0.0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            double[] array = { 1.0, 2.0, 3.0, 4.0, 5.0 };
            double sum = SumArray(array);
            Console.WriteLine("Sum of array elements: " + sum); // 15

            // Of course we could do the following:
            Console.WriteLine(array.Sum()); // 15
            // But the function above shows the inner workings.
        }
    }
}
