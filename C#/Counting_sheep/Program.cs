namespace Counting_sheep
{
    internal class Program
    {
        public static int CountSheeps(bool[] sheeps)
        {
            int counter = 0;
            foreach (bool sheep in sheeps)
            {
                if (sheep == true)
                {
                    counter++;
                }
            }
            return counter;
        }

        static void Main(string[] args)
        {
            bool[] sheeps = { true, false, true, true, false, true, true, true, false, true, true, false, true, false, false, true, true, true, true, true, false, false, true, true };
            Console.WriteLine(CountSheeps(sheeps));  // 16
        }
    }
}
