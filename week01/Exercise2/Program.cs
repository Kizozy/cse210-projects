using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int gradePercentage = int.Parse(input);
        string final = "";

        if (gradePercentage % 10 >= 7)
        {
            final = "+";
        }
        else if (gradePercentage % 10 <= 3)
        {
            final = "-";
        }
        else
        {
            final = "";
        }
        if (gradePercentage >= 97)
        {
            Console.WriteLine("Your grade is: A");
        }
        else if (gradePercentage >= 90)
        {
            Console.WriteLine("Your grade is: A" + final);
        }
        else if (gradePercentage >= 80)
        {
            Console.WriteLine("Your grade is: B" + final);
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine("Your grade is: C" + final);
        }
        else if (gradePercentage >= 60)
        {
            Console.WriteLine("Your grade is: D" + final);
        }
        else
        {
            Console.WriteLine("Your grade is: F");
        }
            if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the class.");
        }
            else
        {
            Console.WriteLine("Sorry, you did not pass the class but keep trying you can make it next time.");
        }
    }
}