using System;

namespace Tricentis
{
    class Program
    {

        private static IntegerComparer comparer;
        private static IntegerGuessManager integerGuessManager;

        static void Main(string[] args)
        {
            var rd = new Random().Next(0, 100);
            comparer = new IntegerComparer(rd);
            integerGuessManager = new IntegerGuessManager();

            var correctlyGuessed = false;
            while (!correctlyGuessed)
            {
                int guessedValue = 0;
                try
                {
                    guessedValue = integerGuessManager.GetGuess();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }

                var comparisonResult = comparer.CompareTheIntegers(guessedValue);
                if (comparisonResult == "equal")
                {
                    Console.WriteLine("It is a correct answer");
                    correctlyGuessed = true;
                }
                else
                {
                    Console.WriteLine($"your guess is {comparisonResult} than the expected number");
                }
            }
        }
    }
}
