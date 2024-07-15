using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        // Eternal goal logic
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{Name},{Description},{Points}";
    }

    public override string GetDetailsString()
    {
        return $"[Eternal] {Name} - {Description} - {Points} points";
    }
}
