using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user to enter the grade percentage
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);
        
        // Strech Challenge added (+ or - sign) and i have added description to make it more fun.
        string letter = "";
        string description = "";
        string sign = "";

        // Determine the letter grade and description
        if (percent >= 90)
        {
            letter = "A";
            description = "Excellent";
        }
        else if (percent >= 80)
        {
            letter = "B";
            description = "Very Good";
        }
        else if (percent >= 70)
        {
            letter = "C";
            description = "Good";
        }
        else if (percent >= 60)
        {
            letter = "D";
            description = "Pass";
        }
        else
        {
            letter = "F";
            description = "Fail";
        }

        // Determine the sign for the grade
        if (letter != "A" && letter != "F")
        {
            int lastDigit = percent % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Special cases for specific grades
        if (letter == "B" && sign == "+")
        {
            description = "Very Good";
        }
        else if (letter == "C" && sign == "+")
        {
            description = "Good";
        }
        else if (letter == "D" && sign == "+")
        {
            description = "Pass";
        }

        // Display the final grade and description
        Console.WriteLine($"Your grade is: {letter}{sign} ({description})");

        // Display the pass/fail message
        if (percent >= 60)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}
