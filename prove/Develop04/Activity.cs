using System;
using System.Collections.Generic;
using System.Threading;

namespace MindfulnessApp
{
    public abstract class Activity
    {
        protected string _name; // Name of the activity
        protected string _description; // Description of the activity
        protected int _duration; // Duration of the activity in seconds

        // Public properties to access the name and description of the activity
        public string Name => _name;
        public string Description => _description;

        private List<string> _spinnerAnimation = new List<string> { "/", "-", "\\", "|" };

        // Method to set the duration of the activity
        public void SetDuration(int duration)
        {
            _duration = duration;
        }

        // Method to display a starting message for the activity
        public void DisplayStartingMessage()
        {
            Console.WriteLine($"Starting {Name} Activity...");
            Console.WriteLine(Description);
            Console.WriteLine("Prepare to begin...");
            ShowSpinner(3); // Show a spinner for 3 seconds to simulate preparation time
        }

        // Method to display an ending message for the activity
        public void DisplayEndingMessage()
        {
            Console.WriteLine($"Great job! You have completed the {Name} activity for {_duration} seconds.");
            ShowSpinner(3); // Show a spinner for 3 seconds to simulate ending time
        }

        // Method to show a spinner animation for a specified number of seconds
        public void ShowSpinner(int seconds)
        {
            int counter = 0;
            for (int i = 0; i < seconds * 4; i++)
            {
                Console.Write(_spinnerAnimation[counter % _spinnerAnimation.Count]);
                Thread.Sleep(250);
                Console.Write("\b");
                counter++;
            }
        }

        // Method to show a countdown from a specified number of seconds
        public void ShowCountDown(int seconds)
        {
            for (int i = seconds; i > 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000); // Wait for 1 second between each countdown number
            }
        }

        // Abstract method to be implemented by subclasses to define the specific behavior of the activity
        public abstract void Run();
    }
}
