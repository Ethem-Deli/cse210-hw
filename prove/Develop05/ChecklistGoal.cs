using System;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _bonusPoints;
    private int _currentCount;

    public int TargetCount
    {
        get => _targetCount;
        private set => _targetCount = value;
    }

    public int BonusPoints
    {
        get => _bonusPoints;
        private set => _bonusPoints = value;
    }

    public int CurrentCount
    {
        get => _currentCount;
        private set => _currentCount = value;
    }

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints) 
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = 0;
    }

    public override void RecordEvent()
    {
        // Checklist goal logic
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{Name},{Description},{Points},{TargetCount},{BonusPoints}";
    }

    public override string GetDetailsString()
    {
        return $"[Checklist] {Name} - {Description} - {Points} points - Target: {TargetCount} - Bonus: {BonusPoints}";
    }
}
