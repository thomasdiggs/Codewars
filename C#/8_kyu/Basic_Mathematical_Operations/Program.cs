namespace Basic_Mathematical_Operations
{
    internal class Program
    {
        public static double BasicOp(char operation, double value1, double value2)
        {
            double result = double.NaN;
            switch (operation)
            {
                case '+':
                    result = value1 + value2;
                    break;
                case '-':
                    result = value1 - value2;
                    break;
                case '*':
                    result = value1 * value2;
                    break;
                case '/':
                    result = value1 / value2;
                    break;
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(BasicOp('+', 4, 7));      // 11
            Console.WriteLine(BasicOp('-', 15, 18));    // -3
            Console.WriteLine(BasicOp('*', 5, 5));      // 25
            Console.WriteLine(BasicOp('/', 49, 7));     // 7
        }
    }
}
