using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Exceeds Core Requirement 1: Dynamically determines the path for the scriptures file and ensures the file is present in the output directory.
        string sourceFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\scriptures.txt");
        string destinationFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "scriptures.txt");

        // Method to Check if the file exists in the output directory
        if (!File.Exists(destinationFilePath))
        {
            if (File.Exists(sourceFilePath))
            {
                //Method to Copy the file from the source directory to the output directory
                File.Copy(sourceFilePath, destinationFilePath);
            }
            else
            {
                Console.WriteLine("Error: scriptures.txt file not found.");
                return;
            }
        }

        // Exceeds Core Requirement 2: Exception handling when loading scriptures from the file
        // also its provides user-friendly error messages in case of errors.
        ScripturesLibrary library;
        try
        {
            library = new ScripturesLibrary(destinationFilePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading scriptures: {ex.Message}");
            return;
        }

        // Get a random scripture
        Scripture scripture = library.GetRandomScripture();

        // Main loop
        while (true)
        {
            // Clear the console
            Console.Clear();

            // Display the scripture
            Console.WriteLine(scripture.GetDisplayText());

            // Check if the scripture is completely hidden then display a message 
            if (scripture.IsCompletelyHidden()) 
            {
                Console.WriteLine("All words are hidden. You have completed the memorization!");
                break;
            }

            // Prompt the user to press enter or type 'quit'
            Console.WriteLine("Press Enter to hide more words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            // Exceeds Core Requirement 3: Hide a configurable number of random words (3 in this case)
            // The number of words hidden can be easily adjusted.
            scripture.HideRandomWords(3);
        }
    }
}

// This code has exceeded the core requirements by implementing dynamic file handling, exception handling, 
// random scripture selection, configurable word hiding, and providing a user-friendly interface with clear 
// prompts and a clean console display.the code also has 2 different class such as "ScripturesLibrary" and "Scriptures.txt" file
// to ensure it has more than 1 Scriptures as i have added 44 Scripture from what i wish to memorize and i added the Article of Faith as its my favorites..
