
namespace Vowel_Count
{
    internal class Program
    {
        // Loved this solution from another Codewars member
        // return str.Count(i => "aeiou".Contains(i));

        public static int GetVowelCunt(string str)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int count = 0;
            char[] strArray = str.ToCharArray();
            foreach (var c in strArray)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetVowelCunt("hello"));           // 2
            Console.WriteLine(GetVowelCunt("why"));             // 0
            Console.WriteLine(GetVowelCunt("why do you ask?")); // 4
        }
    }
}
