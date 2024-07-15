using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        // Simple goal logic
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{Name},{Description},{Points}";
    }

    public override string GetDetailsString()
    {
        return $"[Simple] {Name} - {Description} - {Points} points";
    }
}
