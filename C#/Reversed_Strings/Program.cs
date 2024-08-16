namespace Reversed_Strings
{
    internal class Program
    {
        public static string Solution(string str)
        {
            char[] chars = str.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Solution("hello")); // olleh
            Console.WriteLine(Solution("world")); // dlrow
        }
    }
}
