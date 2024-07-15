using System;

public class MilestoneGoal : Goal
{
    private int _milestonePoints;

    public int MilestonePoints
    {
        get => _milestonePoints;
        private set => _milestonePoints = value;
    }

    public MilestoneGoal(string name, string description, int points, int milestonePoints)
        : base(name, description, points)
    {
        _milestonePoints = milestonePoints;
    }

    public override void RecordEvent()
    {
        // Milestone goal logic
    }

    public override string GetStringRepresentation()
    {
        return $"MilestoneGoal:{Name},{Description},{Points},{MilestonePoints}";
    }

    public override string GetDetailsString()
    {
        return $"[Milestone] {Name} - {Description} - {Points} points - Milestone: {MilestonePoints}";
    }
}
