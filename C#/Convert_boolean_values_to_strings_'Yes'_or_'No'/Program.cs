namespace Convert_boolean_values_to_strings__Yes__or__No_
{
    internal class Program
    {
        public static string BoolToWord(bool word)
        {
            return word ? "Yes" : "No";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(BoolToWord(true)); // Yes
            Console.WriteLine(BoolToWord(false)); // No
        }
    }
}
