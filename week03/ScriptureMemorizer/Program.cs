using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> library = new List<Scripture>
        {
            new Scripture(
                new Reference("Proverbs", 3, 5-6),
                "Trusting the Lord for guidance rather than self-reliance."
            ),
            new Scripture(
                new Reference("Romans", 8, 28),
                "All things working together for good for those who love God."
            ),
            new Scripture(
                new Reference("Romans", 12, 2),
                "And do not be conformed to this world, but be transformed by the renewing of your mind, that you may prove what is that good and acceptable and perfect will of God."
            ),
            new Scripture(
                new Reference("Psalm", 121, 7-8),
                "The Lord will keep you from all harm and will watch over your life."
            ),
            new Scripture(
                new Reference("Romans", 5, 8),
                "But God demonstrates his own love for us in this: While we were still sinners, Christ died for us."
            ),
            new Scripture(
                new Reference("James", 1, 19-20),
                "Let every person be quick to hear, slow to speak, and slow to anger."
            ),
            new Scripture(
                new Reference("2 Timothy", 3, 16-17),
                "All Scripture is inspired by God and is useful for teaching, rebuking, correcting, and training in righteousness."
            ),
            new Scripture(
                new Reference("Psalm", 121, 7-8),
                "The Lord will keep you from all harm and will watch over your life."
            ),
            new Scripture(
                new Reference("Hebrews", 11, 1),
                "For by faith we understand that the universe was created by the word of God, so that what is seen was not made out of things that are visible."
            )
            
        };

        Random random = new Random();
        Scripture scripture = library[random.Next(library.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine() ?? "";

            if (input.Trim().Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}