namespace Solutions
{
    class NumberGeneratorSolutions
    {
        public static void NumberGenerator(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 4 == 0)
                {
                    Console.Write("OKYES ");
                }
                else if (i % 4 == 0)
                {
                    Console.Write("YES ");
                }
                else if (i % 3 == 0)
                {
                    Console.Write("OK ");
                }
                else
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}