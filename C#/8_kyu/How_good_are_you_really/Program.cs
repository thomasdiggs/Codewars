using System.Linq;

namespace How_good_are_you_really
{
    internal class Program
    {
        public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            int sum = 0, avg = 0;
            for (int i = 0; i < ClassPoints.Length; i++)
            {
                sum += ClassPoints[i];
            }
            avg = sum / ClassPoints.Length;
            return YourPoints > avg;
        }

        public static bool BetterWayToBetterThanAverage(int[] ClassPoints, int YourPoints)
        {
            return YourPoints > ClassPoints.Average();
        }

        static void Main(string[] args)
        {
            int[] classPoints = { 100, 101, 102, 103 };
            int yourPoints = 102;
            Console.WriteLine(BetterThanAverage(classPoints, yourPoints));  // True
            Console.WriteLine(BetterWayToBetterThanAverage(classPoints, yourPoints));  // True
        }
    }
}
