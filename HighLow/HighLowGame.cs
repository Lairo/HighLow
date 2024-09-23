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

        public static int GetPot()
        {
            int Pot = pot;
            return Pot;
        }

        public static void Guess(bool higher)
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

        public static void Hint()
        {
            int half = MAXIMUM / 2;
            if (currentNumber > half)
            {
                Console.WriteLine($"\n\tThe current number is {currentNumber}, the next number is at least {half}.\n");
            }
            else Console.WriteLine($"\n\tThe current number is {currentNumber}, the next number is less than {half}.\n");
            pot--;
        }
    }
}
