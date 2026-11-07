using System;

class Program
{
    static void Main(string[] args)
    {
        string keepPlaying = "yes";
        Random random = new Random();

        while (keepPlaying.ToLower() == "yes")
        {
            int magicNumber = random.Next(1, 101);
            int guessCount = 0;
            int guess = -1;

            Console.WriteLine("\nI'm thinking of a number between 1 and 100.");

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                
                if (int.TryParse(Console.ReadLine(), out guess))
                {
                    guessCount++;

                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine($"You guessed it! It took you {guessCount} guesses.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer.");
                }
            }

            Console.Write("Do you want to play again? (yes/no): ");
            keepPlaying = Console.ReadLine()?.Trim() ?? "no";
        }

        Console.WriteLine("Thanks for playing!");
    }
}