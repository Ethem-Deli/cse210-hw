using System;
using System.Collections.Generic;
using System.IO;

public class GoalTracker
{
    private List<Goal> _goals;
    private int _totalPoints;

    public GoalTracker()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
        Console.WriteLine("Goal added successfully.");
    }

    public void ListGoals()
    {
        Console.WriteLine("Your Goals:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
        Console.WriteLine($"Total Points: {_totalPoints}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
            outputFile.WriteLine($"TotalPoints:{_totalPoints}");
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals(string filename)
    {
        string[] lines = File.ReadAllLines(filename);

        _goals.Clear();
        foreach (string line in lines)
        {
            if (line.StartsWith("TotalPoints:"))
            {
                _totalPoints = int.Parse(line.Substring(12));
                continue;
            }

            string[] parts = line.Split(':');
            string type = parts[0];
            string[] details = parts[1].Split(',');

            switch (type)
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(details[0], details[1], int.Parse(details[2])));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(details[0], details[1], int.Parse(details[2])));
                    break;
                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[3]), int.Parse(details[4])));
                    break;
                case "NegativeGoal":
                    _goals.Add(new NegativeGoal(details[0], details[1], int.Parse(details[2])));
                    break;
                case "BonusGoal":
                    _goals.Add(new BonusGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[3]), int.Parse(details[4])));
                    break;
                case "MilestoneGoal":
                    _goals.Add(new MilestoneGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[3])));
                    break;
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }

    public void RecordEvent(string goalName)
    {
        var goal = _goals.Find(g => g.Name == goalName);
        if (goal != null)
        {
            goal.RecordEvent();
            _totalPoints += goal.Points;
            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    public void DeleteGoal(string goalName)
    {
        var goal = _goals.Find(g => g.Name == goalName);
        if (goal != null)
        {
            _goals.Remove(goal);
            Console.WriteLine("Goal deleted successfully.");
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }
}
