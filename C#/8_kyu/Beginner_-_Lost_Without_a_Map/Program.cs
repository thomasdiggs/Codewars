
using System.Diagnostics;

namespace Beginner___Lost_Without_a_Map
{
    internal class Program
    {
        // I had this first, but Codewars wouldn't accept it
        
        // return x.Select(i => i * 2).ToArray();

        // Learned that you have to include the directive:

        // using System.Linq;
        
        // Yet you do not need to include the directive in Visual Studio

        public static int[] Maps(int[] x)
        {
            int[] y = new int[x.Length];
            for (int i = 0; i < x.Length; i++)
            {
                y[i] = x[i] * 2;
            }
            return y;
        }

        public static int[] Maps2(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] *= 2;
            }
            return x;
        }

        static void Main(string[] args)
        {
            int[] x = { 1, 2, 3, 4, 5 };
            int[] y = Maps(x);
            foreach (int i in y)
            {
                Console.WriteLine(i);
            }

            foreach (int i in x)
            {
                Console.WriteLine(i);
            }
            int[] test = Maps2(x);
            foreach (int i in test)
            {
                Console.WriteLine(i);
            }
            foreach (int i in x)
            {
                Console.WriteLine(i);
            }
        }
    }
}
