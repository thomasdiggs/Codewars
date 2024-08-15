namespace Convert_a_Number_to_a_String_;

class Program
{
    public static string NumberToString(int num)
    {
        return num.ToString();
    }

    static void Main(string[] args)
    {
        Console.WriteLine(NumberToString(123));
    }
}
