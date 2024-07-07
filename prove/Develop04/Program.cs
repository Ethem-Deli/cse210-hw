using System;

namespace MindfulnessApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of ActivityLog to keep track of activities.
            ActivityLog log = new ActivityLog();

            // Load the activity log from a file.
            log.LoadLog();

            // Start an infinite loop to keep the program running until the user chooses to exit.
            while (true)
            {
                // Display the menu for the user to choose an activity.
                Console.WriteLine("Menu options:");
                Console.WriteLine("1. Start Breathing Activity");
                Console.WriteLine("2. Start Reflecting Activity");
                Console.WriteLine("3. Start Listing Activity");
                Console.WriteLine("4. Start Visualization Activity");
                Console.WriteLine("5. Start Gratitude Activity");
                Console.WriteLine("6. Quit");
                Console.WriteLine("Select a choice from the menu: ");

                // Read the user's choice.
                int choice = int.Parse(Console.ReadLine());

                Activity activity = null;

                // Depending on the user's choice, create an instance of the appropriate activity.
                switch (choice)
                {
                    case 1:
                        activity = new BreathingActivity();
                        break;
                    case 2:
                        activity = new ReflectingActivity();
                        break;
                    case 3:
                        activity = new ListingActivity();
                        break;
                    case 4:
                        activity = new VisualizationActivity();
                        break;
                    case 5:
                        activity = new GratitudeActivity();
                        break;
                    case 6:
                        // Save the activity log and exit the program if the user chooses to exit.
                        log.SaveLog();
                        return;
                }

                // Display welcome and description messages
                Console.WriteLine($"Welcome to the {activity.Name} Activity.");
                Console.WriteLine(activity.Description);

                // Prompt the user to enter the duration for the activity.
                Console.Write("How long, in seconds, would you like for your session? ");
                int duration = int.Parse(Console.ReadLine());

                // Set the duration for the activity.
                activity.SetDuration(duration);

                // Run the selected activity.
                activity.Run();

                // Record the activity in the log
                log.RecordActivity($"{activity.Name} Activity");

                // Display the count of the activity
                int activityCount = log.GetActivityCount($"{activity.Name} Activity");
                Console.WriteLine($"You have completed the {activity.Name} Activity {activityCount} times.");
            }
        }
    }
}

// The program not only meets all the core requirements but also includes several enhancements that go beyond the basic specifications:
// 1. I added a new activity type, GratitudeActivity. This activity encourages users to reflect on things they are grateful for, adding variety and depth to the mindfulness exercises.
// 2. The ActivityLog class now keeps a detailed log of activities, recording how many times each activity has been performed. This log is saved to a file and loaded each time the program runs, providing persistent tracking of the user's mindfulness practices.
// 3. The program ensures that no random prompts are reused until all prompts have been used at least once in the current session. This prevents repetition and keeps the activities fresh and engaging.
// 4. I enhanced the breathing activity with a meaningful animation that visually represents the breathing process, making it easier for users to follow along and stay engaged.
// 5. The code adheres to best practices for encapsulation, inheritance, and naming conventions, ensuring it is well-organized and easy to maintain.
// 6. User interaction is enhanced with clear, informative messages that guide the user through each step of the activities, creating a smooth and user-friendly experience.