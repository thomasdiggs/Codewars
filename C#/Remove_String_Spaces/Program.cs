namespace Remove_String_Spaces
{
    internal class Program
    {
        public static string NoSpace(string input)
        {
            return input.Replace(" ", "");
        }

        static void Main(string[] args)
        {
            Console.WriteLine(NoSpace("8 j 8   mBliB8g  imjB8B8  jl  B"));              // 8j8mBliB8gimjB8B8jlB
            Console.WriteLine(NoSpace("8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd"));  // 88Bifk8hB8BB8BBB888chl8BhBfd
        }
    }
}
