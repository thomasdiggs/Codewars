namespace A_Needle_in_the_Haystack
{
    internal class Program
    {
        public static string FindNeedle(object[] haystack)
        {
            return $"found the needle at position {Array.IndexOf(haystack, "needle")}";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(FindNeedle(new object[] { '3', "123124234", null, "needle", "world", "hay", 2, '3', true, false })); // found the needle at position 3
        }
    }
}
