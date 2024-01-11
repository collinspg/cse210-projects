using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        do
        {
            PlayGame();
            Console.Write("Do you want to play again? (yes/no): ");
        } while (Console.ReadLine().ToLower() == "yes");

        Console.WriteLine("Thank you for playing. Goodbye!");
    }

    static void PlayGame()
    {

        // Parts 1 and 2
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        // Part 3
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        int guessCount = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            guessCount++;

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                string pluralSuffix = (guessCount == 1) ? "" : "es";
                Console.WriteLine($"You guessed it in {guessCount} guess{pluralSuffix}!");
            }
        }
    }
}