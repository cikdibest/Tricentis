using System;
using System.Collections.Generic;

namespace Tricentis
{
    public class IntegerGuessManager
    {
        private const string EnterAValidInteger = "Please enter a valid integer!";
        private List<int> guessList = new List<int>();
        public int GetGuess()
        {
            Console.WriteLine("Guess The Number");

            var enteredString = Console.ReadLine();
            int enteredInteger;

            if (!int.TryParse(enteredString, out enteredInteger))
            {
                throw new ArgumentException(EnterAValidInteger);
            }
            guessList.Add(enteredInteger);
            return enteredInteger;
        }

        public List<int> GetGuessList()
        {
            return guessList;
        }
    }
}
