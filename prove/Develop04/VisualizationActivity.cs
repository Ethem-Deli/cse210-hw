using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class VisualizationActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Imagine yourself in a peaceful meadow, surrounded by nature.",
            "Visualize achieving one of your biggest goals.",
            "Picture yourself on a calm beach, listening to the waves."
        }; // List of visualization prompts

        private HashSet<int> _usedPrompts = new HashSet<int>(); // Set to keep track of used prompts

        public VisualizationActivity()
        {
            _name = "Visualization"; // Set the name of the activity
            _description = "This activity will guide you through a visualization exercise to promote relaxation and positive thinking."; // Set the description
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
            ShowSpinner(_duration); // Show a spinner for the duration of the activity

            DisplayEndingMessage(); // Display the ending message for the activity
        }
    }
}
