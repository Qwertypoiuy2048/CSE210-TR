using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello Prep3 World!");
        int guess =0;
        int target =0;
        int guesses =0;
        char playAgain = 'Y';

        do 
        {
            // Console.Write("What is the magic number? ");
            // target = int.Parse(Console.ReadLine());

            Random randomGenerator = new Random();
            target = randomGenerator.Next(1, 100);

            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                if (guess > target)
                {
                    Console.WriteLine("Lower");
                } else if (guess < target)
                {
                    Console.WriteLine("Higher");
                }
                guesses = guesses +1;
            } while (guess != target);
            Console.Write("You guessed it in ");
            Console.Write(guesses);
            Console.WriteLine(" guesses!");
            
            Console.Write("Play again? [Y/N] ");
            playAgain = char.Parse(Console.ReadLine());
        } while (playAgain == 'Y' || playAgain == 'y');
    }
}