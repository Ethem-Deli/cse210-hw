using System;

public class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points) : base(name, description, points) { }

    public override void RecordEvent()
    {
        // Negative goal logic
    }

    public override string GetStringRepresentation()
    {
        return $"NegativeGoal:{Name},{Description},{Points}";
    }

    public override string GetDetailsString()
    {
        return $"[Negative] {Name} - {Description} - {Points} points";
    }
}
