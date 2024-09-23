using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow
{
    static class HighLowGame
    {
        public const int MAXIMUM = 10;
        private static int currentNumber = Random.Shared.Next(1, MAXIMUM + 1);
        private static int nextNumber = Random.Shared.Next(1, MAXIMUM + 1);
        private static int pot = 10;

        private static int GetPot(int pot)
        {
            int Pot = pot;
            return Pot;
        }

        static void Guess(bool higher)
        {
            if ((higher & nextNumber >= currentNumber ) ||
                (!higher & nextNumber <= currentNumber))
            {
                Console.WriteLine("You guessed right!");
                pot++;
            }
            
            else
            {
                Console.WriteLine("Bad luck, you guessed wrong.");
                pot--;
            }
            currentNumber = nextNumber;
            nextNumber = Random.Shared.Next(1, MAXIMUM + 1);

            Console.WriteLine($"The current number is {currentNumber}.");
        }

        static void Hint()
        {
            throw new NotImplementedException();
        }
    }
}
