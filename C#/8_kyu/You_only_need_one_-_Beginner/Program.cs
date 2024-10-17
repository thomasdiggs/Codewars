
namespace You_only_need_one___Beginner
{
    internal class Program
    {
        // Array can contain numbers and strings. X can be either.
        public static bool Check(object[] a, object x)
        {
            bool found = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Equals(x))
                {
                    found = true;
                }
            }
            return found;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Check(new object[] { 66, 101 }, 66)); // true
            Console.WriteLine(Check(new object[] { 80, 117, 115, 4, 97, 118, 97 }, 107)); // false
            Console.WriteLine(Check(new object[] { 't', 'e', 's', 't' }, 'e')); // true
            Console.WriteLine(Check(new object[] { "what", "a", "great", "kata" }, "kat")); // false
        }
    }
}
