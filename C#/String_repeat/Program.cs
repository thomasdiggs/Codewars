namespace String_repeat
{
    internal class Program
    {
        public static string RepeatStr(int n, string s)
        {
            string output = "";
            for (int i = 0; i < n; i++)
            {
                output += s;
            }
            return output;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(RepeatStr(6, "I"));   // "IIIIII"
            Console.WriteLine(RepeatStr(5, "#"));   // "#####"
            Console.WriteLine(RepeatStr(2, "ha"));  // "haha"
        }
    }
}
