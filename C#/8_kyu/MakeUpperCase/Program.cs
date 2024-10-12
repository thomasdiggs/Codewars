
namespace MakeUpperCase
{
    internal class Program
    {
        public static string MakeUpperCase(string str) => str.ToUpper();

        static void Main(string[] args)
        {
            Console.WriteLine(MakeUpperCase("hello"));  // HELLO
        }
    }
}
