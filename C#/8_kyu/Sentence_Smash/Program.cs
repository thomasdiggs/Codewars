
namespace Sentence_Smash
{
    internal class Program
    {
        public static string Smash(string[] words)
        {
            string sentence = "";
            for (int i = 0; i < words.Length; i++)
            {
                sentence += words[i];
                if (i != (words.Length - 1))
                {
                    sentence += " ";
                }
            }
            return sentence;
        }

        // This is the same logic as the above method, but it uses the built-in string.Join method
        // Nice to know what is going on behind these methods
        public static string SmashySmashy(string[] words)
        {
            return string.Join(" ", words);
        }

        static void Main(string[] args)
        {
            string[] words = new string[] { "hello", "world", "this", "is", "a", "sentence" };
            Console.WriteLine(Smash(words));
            string[] words2 = new string[] { "hello" };
            Console.WriteLine(Smash(words2));
            string[] words3 = new string[] { "hello", "world" };
            Console.WriteLine(Smash(words3));
            string[] words4 = new string[] { "hello", "world", "this", "is", "a", "sentence" };
            Console.WriteLine(SmashySmashy(words4));
        }
    }
}
