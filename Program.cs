using Solutions;

namespace AlgorithmAndQuery{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Number Generator Solutions : ");
            int number = 15;
            NumberGeneratorSolutions.NumberGenerator(number);

            Console.WriteLine("\n\nNumber Pattern Generator Solutions : ");
            int numeric = 5;
            Console.WriteLine("a. ");
            NumberPatternGeneratorSolutions.GenerateAscendingNumberPyramid(numeric);
            Console.WriteLine("\nb. ");
            NumberPatternGeneratorSolutions.GenerateDescendingNumberPyramid(numeric);
            Console.Write("\nc. ");
            NumberPatternGeneratorSolutions.GenerateSpecialNumberPyramid(numeric);
            Console.WriteLine("\nd. ");
            NumberPatternGeneratorSolutions.GenerateNumberSquare(numeric);

            Console.WriteLine("\n\nConditional Array Remover Solutions : ");
            int [] numberOfArray = {12, 9, 13, 6, 10, 4, 7, 2};
            ConditionalArrayRemover.ArrayRemover(numberOfArray);
        }
    }
}
