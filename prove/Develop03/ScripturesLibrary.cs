using System;
using System.Collections.Generic;
using System.IO;

public class ScripturesLibrary
{
    private List<Scripture> _scriptures;
    private Random _random;

    public ScripturesLibrary(string filePath)
    {
        _scriptures = new List<Scripture>();
        _random = new Random();
        LoadScripturesFromFile(filePath);

        if (_scriptures.Count == 0)
        {
            throw new InvalidOperationException("No scriptures loaded.");
        }
    }

    private void LoadScripturesFromFile(string filePath)
    {
        var lines = File.ReadAllLines(filePath);
        Console.WriteLine($"Total lines read from file: {lines.Length}");
        foreach (var line in lines)
        {
            Console.WriteLine($"Processing line: {line}");
            try
            {
                var parts = line.Split('|');
                if (parts.Length == 2)
                {
                    string reference = parts[0];
                    string text = parts[1];
                    var refParts = reference.Split(' ');
                    var book = refParts[0];
                    var chapterAndVerse = refParts[1].Split(':');
                    var chapter = int.Parse(chapterAndVerse[0]);
                    var verse = chapterAndVerse[1].Contains("-") ? int.Parse(chapterAndVerse[1].Split('-')[0]) : int.Parse(chapterAndVerse[1]);
                    var endVerse = chapterAndVerse[1].Contains("-") ? int.Parse(chapterAndVerse[1].Split('-')[1]) : verse;
                    var refObject = new Reference(book, chapter, verse, endVerse);
                    _scriptures.Add(new Scripture(refObject, text));
                    Console.WriteLine($"Added scripture: {refObject.GetDisplayText()}");
                }
                else
                {
                    Console.WriteLine($"Invalid line format: {line}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error parsing line: {line}. Exception: {ex.Message}");
            }
        }
        Console.WriteLine($"Total scriptures loaded: {_scriptures.Count}");
    }

    public Scripture GetRandomScripture()
    {
        if (_scriptures.Count == 0)
        {
            throw new InvalidOperationException("No scriptures available to select.");
        }

        int index = _random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}
