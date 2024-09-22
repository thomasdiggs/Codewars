namespace Keep_Hydrated_
{
    internal class Program
    {
        public static int Litres(double time)
        {
            return (int)(0.5 * time);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Litres(2));       // 1
            Console.WriteLine(Litres(1.4));     // 0
            Console.WriteLine(Litres(12.3));    // 6
            Console.WriteLine(Litres(0.82));    // 0
            Console.WriteLine(Litres(11.8));    // 5
            Console.WriteLine(Litres(1787));    // 893
            Console.WriteLine(Litres(0));       // 0
        }
    }
}
