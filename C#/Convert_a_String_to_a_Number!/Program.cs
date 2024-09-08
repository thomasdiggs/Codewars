namespace Convert_a_String_to_a_Number_
{
    internal class Program
    {
        public static int StringToNumber(String str)
        {
            return Convert.ToInt32(str);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(StringToNumber("1234"));  // 1234
            Console.WriteLine(StringToNumber("605"));   // 605
        }
    }
}
