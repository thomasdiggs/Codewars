namespace Convert_number_to_reversed_array_of_digits
{
    internal class Program
    {
        public static long[] Digitize(long n)
        {
            string s = n.ToString();
            long[] arr = new long[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                arr[i] = long.Parse(s[s.Length - i - 1].ToString());
            }
            return arr;
        }

        static void Main(string[] args)
        {
            long[] arr = Digitize(12345);   // [5, 4, 3, 2, 1]
            foreach (var i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}