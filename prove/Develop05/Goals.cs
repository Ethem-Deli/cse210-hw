using System;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public string Name
    {
        get => _name;
        protected set => _name = value;
    }

    public string Description
    {
        get => _description;
        protected set => _description = value;
    }

    public int Points
    {
        get => _points;
        protected set => _points = value;
    }

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract string GetStringRepresentation();
    public abstract string GetDetailsString();
}
