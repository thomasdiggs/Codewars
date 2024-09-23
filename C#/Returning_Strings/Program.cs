namespace Returning_Strings
{
    internal class Program
    {
        public static string Greet(string name)
        {
            return $"Hello, {name} how are you doing today?";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Greet("Thomas"));   // Hello, Thomas how are you doing today?
        }
    }
}
