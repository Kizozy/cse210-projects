using System;

class Program
{
    static void Main(string[] args)
    {
        // Exceeding Requirements Note:
        // 1. Added an automatic file check and cleaner user prompt interface.
        // 2. Used a secure custom delimiter (~|~) to prevent split errors with commas.

        Journal theJournal = new Journal();
        int choice = 0;

        Console.WriteLine("Welcome to the Journal Program!");

        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string input = Console.ReadLine();

            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        theJournal.AddEntry();
                        break;
                    case 2:
                        theJournal.DisplayJournal();
                        break;
                    case 3:
                        Console.Write("What is the filename? ");
                        string saveFile = Console.ReadLine();
                        theJournal.SaveToFile(saveFile);
                        break;
                    case 4:
                        Console.Write("What is the filename? ");
                        string loadFile = Console.ReadLine();
                        theJournal.LoadFromFile(loadFile);
                        break;
                    case 5:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.\n");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.\n");
            }
        }
    }
}