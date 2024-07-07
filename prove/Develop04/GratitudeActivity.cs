using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class GratitudeActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Write down three things you are grateful for today.",
            "Think of a person who has positively impacted your life and write them a thank-you note.",
            "Reflect on a recent positive experience and describe why it was meaningful."
        }; // List of gratitude prompts

        private HashSet<int> _usedPrompts = new HashSet<int>(); // Set to keep track of used prompts

        public GratitudeActivity()
        {
            _name = "Gratitude"; // Set the name of the activity
            _description = "This activity will help you reflect on things you are grateful for."; // Set the description
        }

        public override void Run()
        {
            DisplayStartingMessage(); // Display the starting message for the activity
            Console.WriteLine("Get ready..."); // Display the "Get ready..." message
            ShowSpinner(3); // Show a spinner for 3 seconds to simulate preparation time

            // Reset the used prompts set if all prompts have been used
            if (_usedPrompts.Count == _prompts.Count)
                _usedPrompts.Clear();

            Random rand = new Random();
            int promptIndex;

            // Select a random prompt that has not been used in this session
            do
            {
                promptIndex = rand.Next(_prompts.Count);
            } while (_usedPrompts.Contains(promptIndex));

            _usedPrompts.Add(promptIndex); // Add the selected prompt to the used prompts set
            string prompt = _prompts[promptIndex];
            Console.WriteLine(prompt); // Display the selected prompt
            Console.WriteLine("Start reflecting...");
            ShowSpinner(_duration); // Show a spinner for the duration of the activity

            DisplayEndingMessage(); // Display the ending message for the activity
        }
    }
}
