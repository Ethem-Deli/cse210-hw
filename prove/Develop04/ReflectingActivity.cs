using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    public class ReflectingActivity : Activity
    {
        private List<string> _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        }; // List of reflection prompts

        private List<string> _questions = new List<string>
        {
            "How did you feel when it was complete?",
            "What did you learn from the experience?",
            "How did this experience help you grow?",
            "What would you do differently next time?"
        }; // List of reflection questions

        private HashSet<int> _usedPrompts = new HashSet<int>(); // Set to keep track of used prompts

        public ReflectingActivity()
        {
            _name = "Reflecting"; // Set the name of the activity
            _description = "This activity will help you reflect on moments of strength and resilience."; // Set the description
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
            Console.WriteLine("Consider the following prompt:"); // Display the prompt header
            Console.WriteLine($"--- {prompt} ---"); // Display the selected prompt

            // Wait for the user to press enter
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();

            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
            
            foreach (var question in _questions)
            {
                Console.Write("You may begin in: ");
                ShowCountDown(3); // Countdown before showing each question
                
                Console.WriteLine(question);
                ShowSpinner(10); // Animation and time to reflect on each question
            }

            DisplayEndingMessage(); // Display the ending message for the activity
        }
    }
}
