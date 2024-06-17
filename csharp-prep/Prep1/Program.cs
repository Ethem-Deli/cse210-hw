using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the user for their first name. 
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        // Ask the user for their last name.
        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        // print the last name , first name & last name
        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}