namespace Solutions
{
    class NumberPatternGeneratorSolutions
    {
        public static void GenerateAscendingNumberPyramid(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
        }

        public static void GenerateDescendingNumberPyramid(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
        }

        public static void GenerateSpecialNumberPyramid(int number)
        {
            int countNumber = 0;
            bool isAscending = true;

            for (int i = 0; i <= number; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (isAscending)
                    {
                        countNumber++;
                    }
                    else
                    {
                        countNumber--;
                    }
                    Console.Write($"{countNumber} ");
                    if (countNumber == number)
                    {
                        isAscending = false;
                    }
                    else if (countNumber == 1)
                    {
                        isAscending = true;
                    }
                }
                Console.WriteLine();
            }
        }

        public static void GenerateNumberSquare(int number)
        {
            int[,] matrix = new int[number, number];

            int countNumber = 1;
            for (int i = 0; i < number; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < number; j++)
                    {
                        matrix[j, i] = countNumber++;
                    }
                }
                else
                {
                    for (int j = number - 1; j >= 0; j--)
                    {
                        matrix[j, i] = countNumber++;
                    }
                }
            }

            // Print matrix
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write($"{matrix[i, j].ToString().PadRight(4)}");
                }
                Console.WriteLine();
            }
        }
    }
}