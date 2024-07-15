using System;

class Program
{
    static void Main(string[] args)
    {
        GoalTracker goalTracker = new GoalTracker();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Delete Goals");
            Console.WriteLine("7. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal(goalTracker);
                    break;
                case "2":
                    goalTracker.ListGoals();
                    break;
                case "3":
                    SaveGoals(goalTracker);
                    break;
                case "4":
                    LoadGoals(goalTracker);
                    break;
                case "5":
                    RecordEvent(goalTracker);
                    break;
                case "6":
                    DeleteGoal(goalTracker);
                    break;
                case "7":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void CreateNewGoal(GoalTracker goalTracker)
    {
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Negative Goal");
        Console.WriteLine("5. Bonus Goal");
        Console.WriteLine("6. Milestone Goal");
        string typeChoice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (typeChoice)
        {
            case "1":
                goalTracker.AddGoal(new SimpleGoal(name, description, points));
                break;
            case "2":
                goalTracker.AddGoal(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                goalTracker.AddGoal(new ChecklistGoal(name, description, points, target, bonus));
                break;
            case "4":
                goalTracker.AddGoal(new NegativeGoal(name, description, points));
                break;
            case "5":
                Console.Write("Enter frequency: ");
                int frequency = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                goalTracker.AddGoal(new BonusGoal(name, description, points, frequency, bonusPoints));
                break;
            case "6":
                Console.Write("Enter milestone points: ");
                int milestonePoints = int.Parse(Console.ReadLine());
                goalTracker.AddGoal(new MilestoneGoal(name, description, points, milestonePoints));
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    static void SaveGoals(GoalTracker goalTracker)
    {
        Console.Write("Enter filename to save goals: ");
        string filename = Console.ReadLine();
        goalTracker.SaveGoals(filename);
    }

    static void LoadGoals(GoalTracker goalTracker)
    {
        Console.Write("Enter filename to load goals: ");
        string filename = Console.ReadLine();
        goalTracker.LoadGoals(filename);
    }

    static void RecordEvent(GoalTracker goalTracker)
    {
        Console.Write("Enter goal name to record event: ");
        string goalName = Console.ReadLine();
        goalTracker.RecordEvent(goalName);
    }

    static void DeleteGoal(GoalTracker goalTracker)
    {
        Console.Write("Enter goal name to delete: ");
        string goalName = Console.ReadLine();
        goalTracker.DeleteGoal(goalName);
    }
}
// Additional functionality added with BonusGoal, NegativeGoal and MilestoneGoal:
// BonusGoal: Allows tracking of goals with periodic bonuses based on a defined frequency.
// MilestoneGoal: Provides significant rewards upon reaching specific milestones within the goal.
// These new goal types offer enhanced tracking and rewarding mechanisms, adding more depth and flexibility to the goal management system.

//BonusGoal:
//Functionality: This type of goal tracks tasks or habits that need to be performed at regular intervals. Users receive periodic bonus points for maintaining consistency.
//Details: The BonusGoal class includes properties for frequency (how often the task should be completed) and bonus points (additional points awarded for meeting the frequency).
//Example: If a user sets a BonusGoal to exercise three times a week with a bonus of 10 points, they receive the bonus points if they meet this frequency.

//MilestoneGoal:
//Functionality: This goal type tracks significant milestones in larger projects or long-term goals, rewarding the user when these milestones are achieved.
//Details: The MilestoneGoal class includes a property for milestone points, which are awarded upon reaching predefined milestones.
//Example: A user working on a project can set a MilestoneGoal to finish the first draft, awarding a large number of points when this milestone is reached.

//NegativeGoal:
//Functionality: This type of goal is used to track behaviors or habits that a user wants to avoid. When a user fails to avoid these behaviors, they lose points.
//Details: The NegativeGoal class inherits from the Goal base class, utilizing the common properties of Name, Description, and Points. When a negative event is recorded, the user loses points instead of gaining them.
//Example: If a user sets a NegativeGoal to "Avoid eating junk food" with a penalty of -5 points, they lose 5 points each time they eat junk food.