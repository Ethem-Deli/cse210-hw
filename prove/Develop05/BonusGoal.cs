using System;

public class BonusGoal : Goal
{
    private int _frequency;
    private int _bonusPoints;

    public int Frequency
    {
        get => _frequency;
        private set => _frequency = value;
    }

    public int BonusPoints
    {
        get => _bonusPoints;
        private set => _bonusPoints = value;
    }

    public BonusGoal(string name, string description, int points, int frequency, int bonusPoints)
        : base(name, description, points)
    {
        _frequency = frequency;
        _bonusPoints = bonusPoints;
    }

    public override void RecordEvent()
    {
        // Bonus goal logic
    }

    public override string GetStringRepresentation()
    {
        return $"BonusGoal:{Name},{Description},{Points},{Frequency},{BonusPoints}";
    }

    public override string GetDetailsString()
    {
        return $"[Bonus] {Name} - {Description} - {Points} points - Frequency: {Frequency} - Bonus: {BonusPoints}";
    }
}
