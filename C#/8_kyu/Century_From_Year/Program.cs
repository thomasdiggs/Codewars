namespace Century_From_Year
{
    internal class Program
    {
        public static int СenturyFromYear(int year)
        {
            return year % 100 == 0 ? year / 100 : year / 100 + 1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(СenturyFromYear(1705));    // 18
            Console.WriteLine(СenturyFromYear(1900));    // 19
            Console.WriteLine(СenturyFromYear(1601));    // 17
            Console.WriteLine(СenturyFromYear(2000));    // 20
            Console.WriteLine(СenturyFromYear(89));      // 1
        }
    }
}
