namespace Solutions
{
    class ConditionalArrayRemover
    {
        public static void ArrayRemover(int[] arr)
        {
            int count = CountElementsNotDivisibleByThree(arr);

            int[] newArr = new int[count];
            int index = 0;

            foreach (int value in arr)
            {
                if (value % 3 != 0)
                {
                    newArr[index] = value;
                    index++;
                }
            }

            BubbleSort.Sort(newArr);
            DisplayResult(arr);
            Console.WriteLine("\nOutput : ");
            DisplayResult(newArr);
        }

        private static int CountElementsNotDivisibleByThree(int[] arr)
        {
            int count = 0;
            foreach (int value in arr)
            {
                if (value % 3 != 0)
                {
                    count++;
                }
            }
            return count;
        }

        private static void DisplayResult(int[] arr)
        {
            foreach (int value in arr)
            {
                Console.Write($"{value} ");
            }
        }
    }
}