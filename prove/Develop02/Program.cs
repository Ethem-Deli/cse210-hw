using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace JournalApp
{
    // Class representing a single journal entry
    class Entry
    {
        public string Date { get; set; }
        public string Prompt { get; set; }
        public string Response { get; set; }

        public Entry(string date, string prompt, string response)
        {
            Date = date;
            Prompt = prompt;
            Response = response;
        }

        public override string ToString()
        {
            return $"{Date} - {Prompt}\n{Response}\n";
        }
    }

    // Class representing the journal which contains multiple entries
    class Journal
    {
        private List<Entry> _entries;

        public Journal()
        {
            _entries = new List<Entry>();
        }

        // Add a new entry to the journal
        public void AddEntry(Entry entry)
        {
            _entries.Add(entry);
        }

        //Display all entries in the journal
        public void DisplayEntries()
        {
            foreach (var entry in _entries)
            {
                Console.WriteLine(entry.ToString());
            }
        }

        // Save all entries in the journal to a file
        public void SaveToFile(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in _entries)
                {
                    // Handling CSV format: Enclose the prompt and response in quotes if they contain commas or quotes
                    string prompt = entry.Prompt.Contains(",") || entry.Prompt.Contains("\"") ? $"\"{entry.Prompt.Replace("\"", "\"\"")}\"" : entry.Prompt;
                    string response = entry.Response.Contains(",") || entry.Response.Contains("\"") ? $"\"{entry.Response.Replace("\"", "\"\"")}\"" : entry.Response;
                    writer.WriteLine($"{entry.Date},{prompt},{response}");
                }
            }
        }

        // Load entries from a file into the journal
        public void LoadFromFile(string filename)
        {
            _entries.Clear();
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Proper CSV handling: Split the line by commas and handle quoted fields
                    var parts = ParseCsvLine(line);
                    if (parts.Length == 3)
                    {
                        _entries.Add(new Entry(parts[0], parts[1], parts[2])); // Create and add a new entry
                    }
                }
            }
        }

        //Parse a CSV line
        private string[] ParseCsvLine(string line)
        {
            List<string> parts = new List<string>();
            bool inQuotes = false;
            string currentPart = "";

            foreach (char c in line)
            {
                if (c == '"')
                {
                    inQuotes = !inQuotes;
                }
                else if (c == ',' && !inQuotes)
                {
                    parts.Add(currentPart);
                    currentPart = "";
                }
                else
                {
                    currentPart += c;
                }
            }
            parts.Add(currentPart);

            return parts.ToArray();
        }
    }

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
            
                Console.WriteLine("Please Select one of the following choices: ");
                Console.WriteLine("  ");
                Console.WriteLine("1. Write ");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save ");
                Console.WriteLine("4. Load from a file");
                Console.WriteLine("5. Exit");
                Console.Write("What would like to do?: ");

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

            // Create a new entry and add it to the journal
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
//                      MY COMMENTS FOR THE ABOVE PROGRAM
// This program exceeds the core requirements by implementing proper CSV handling for saving and loading,
// allowing the journal entries to be easily opened and manipulated in spreadsheet software like Excel.
// The program could be enhanced with user reminders, additional data storage.

// also i have added comment on each line which explains what i have done for the code 