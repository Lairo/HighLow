namespace HighLow
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to High Low.");
            Console.WriteLine($"Guess numbers between 1 and {HighLowGame.MAXIMUM}.");
            HighLowGame.Hint();
            while(HighLowGame.GetPot() > 0)
            {
                Console.WriteLine("Press h for higher, l for lower, ? to buy a hint,");
                Console.WriteLine($"or any other key to quit with {HighLowGame.GetPot()}.");
                char key = Console.ReadKey(true).KeyChar;
                if (key == 'h') HighLowGame.Guess(true);
                else if (key == 'l') HighLowGame.Guess(false);
                else if (key == '?') HighLowGame.Hint();
                else return;                    
            }
            Console.WriteLine("The pot is empty. Bye!");
        }
    }
}
