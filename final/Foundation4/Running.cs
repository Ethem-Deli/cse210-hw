public class Running : Activity
{
    private float _distance; // Distance in kilometers

    public Running(string date, int length, float distance)
        : base(date, length)
    {
        _distance = distance;
    }

    public override float GetDistance()
    {
        return _distance * 0.62f; // Convert km to miles
    }

    public override float GetSpeed()
    {
        return GetDistance() / (GetLength() / 60.0f); // Speed in mph
    }

    public override float GetPace()
    {
        return GetLength() / GetDistance(); // Pace in minutes per mile
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Running";
    }
}
