using System;
using System.Collections.Generic;

namespace JournalApp
{
    class Program
    {
        // List of prompts for journal entries
        static List<string> Prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What happened today?",
            "What was the best thing that happened today?",
            "What was the worst thing that happened today?",
            "What was the most interesting thing I saw or heard today?",
            "What was the most challenging thing I faced today?",
            "What am I grateful for today?",
            "What did I learn today?",
            "What was the most fun thing I did today?",
            "What was the most surprising thing that happened today?",
            "What did I do today that I am proud of?",
            "What is the current problem or challenge I am facing?",
            "What are my goals and objectives related to this problem or challenge?",
            "How can I prioritize and organize my thoughts and ideas to effectively solve this problem or challenge?",
            "How can I apply my skills, knowledge, and experience to this problem or challenge?",
            "What is one challenge or prompt that I can give myself to push myself creatively?"
        };

        static Journal journal = new Journal();
        static Random random = new Random();

        static void Main(string[] args)
        {
            // Main program loop
            while (true)
            {
                // Display menu options to the user
                Console.WriteLine("  ");
                Console.WriteLine("Welcome to Journal App");
                Console.WriteLine("  ");
                Console.WriteLine("Please Select one of the following choices: ");
                Console.WriteLine("  ");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save");
                Console.WriteLine("4. Load from a file");
                Console.WriteLine("5. Exit");
                Console.Write("What would you like to do?: ");

                // Read user input
                string choice = Console.ReadLine();

                // Perform action based on user choice
                switch (choice)
                {
                    case "1":
                        WriteNewEntry();
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        SaveJournal();
                        break;
                    case "4":
                        LoadJournal();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
        }

        // Method to write a new journal entry
        static void WriteNewEntry()
        {
            // Select a random prompt
            string prompt = Prompts[random.Next(Prompts.Count)];
            Console.WriteLine(prompt);

            // Read user response
            string response = Console.ReadLine();

            // Get the current date
            string date = DateTime.Now.ToString("yyyy-MM-dd");

            // Create a new entry and add it to journal
            Entry entry = new Entry(date, prompt, response);
            journal.AddEntry(entry);
        }

        // Method to save the journal to a file
        static void SaveJournal()
        {
            Console.Write("Enter filename to save: ");
            string filename = Console.ReadLine();
            journal.SaveToFile(filename);
        }

        // Method to load the journal from a file
        static void LoadJournal()
        {
            Console.Write("Enter filename to load: ");
            string filename = Console.ReadLine();
            journal.LoadFromFile(filename);
        }
    }
}

// This program exceeds the core requirements by implementing proper CSV handling for saving and loading,
// allowing the journal entries to be easily opened and manipulated in spreadsheet software like Excel.
// The program is structured to make it easier to maintain by separating each class into its own file.
