namespace Remove_First_and_Last_Character
{
    internal class Program
    {
        public static string Remove_char(string s)
        {
            //return s.Substring(1, s.Length - 2);
            // Also could do this, don't forget this clever way!
            return s[1..^1];
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Remove_char("eloquent")); // "loquen"
            Console.WriteLine(Remove_char("country")); // "ountr"
            Console.WriteLine(Remove_char("person")); // "erso"
            Console.WriteLine(Remove_char("place")); // "lac"
        }
    }
}
