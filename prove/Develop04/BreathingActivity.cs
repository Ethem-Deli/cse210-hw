using System;

namespace MindfulnessApp
{
    public class BreathingActivity : Activity
    {
        public BreathingActivity()
        {
            _name = "Breathing"; // Set the name of the activity
            _description = "This activity will help you relax by guiding you through deep breathing."; // Set the description
        }

        public override void Run()
        {
            DisplayStartingMessage(); // Display the starting message for the activity
            Console.WriteLine("Get ready..."); // Display the "Get ready..." message
            ShowSpinner(3); // Show a spinner for 3 seconds to simulate preparation time

            // Loop to perform the breathing activity for the specified duration
            for (int i = 0; i < _duration; i += 10)
            {
                Console.WriteLine("Breathe in...");
                ShowCountDown(5); // Show countdown for breathing in
                ShowBreathingAnimation(5, true); // Show breathing in animation for 5 seconds
                
                Console.WriteLine("Breathe out...");
                ShowCountDown(5); // Show countdown for breathing out
                ShowBreathingAnimation(5, false); // Show breathing out animation for 5 seconds
            }

            DisplayEndingMessage(); // Display the ending message for the activity
        }

        // Method to show a breathing animation for a specified number of seconds
        private void ShowBreathingAnimation(int seconds, bool inhale)
        {
            string breath = inhale ? "Breathe in" : "Breathe out";
            for (int i = 0; i < seconds * 4; i++)
            {
                Console.Write(inhale ? "O" : "o"); // Display different characters for inhale and exhale
                System.Threading.Thread.Sleep(250); // Wait for 250 milliseconds
                Console.Write("\b"); // Remove the character
            }
            Console.WriteLine($"{breath} complete.");
        }
    }
}
