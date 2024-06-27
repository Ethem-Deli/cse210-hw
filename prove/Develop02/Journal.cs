using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    //This class representing journal which contains multiple entries
    class Journal
    {
        private List<Entry> _entries;

        public Journal()
        {
            _entries = new List<Entry>();
        }

        // Add a new entry to journal
        public void AddEntry(Entry entry)
        {
            _entries.Add(entry);
        }

        // Display all entries in journal
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

        // Parse CSV line
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
}
