using System;

public class Activity
{
    private string _date;
    private int _length; // Length in minutes

    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    public virtual float GetDistance()
    {
        return 0;
    }

    public virtual float GetSpeed()
    {
        return 0;
    }

    public virtual float GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date} ({_length} min) - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min/mile";
    }

    protected int GetLength()
    {
        return _length;
    }
}
