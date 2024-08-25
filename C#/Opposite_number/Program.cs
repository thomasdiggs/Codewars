namespace Opposite_number
{
    internal class Program
    {
        public static int Opposite(int number)
        {
            return number * -1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Opposite(1));
        }
    }
}
