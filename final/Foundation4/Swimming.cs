public class Swimming : Activity
{
    private int _laps;
    private const float LapDistanceKm = 0.05f; // Distance per lap in kilometers
    private const float KmToMiles = 0.62f; // Conversion factor from kilometers to miles

    public Swimming(string date, int length, int laps)
        : base(date, length)
    {
        _laps = laps;
    }

    public override float GetDistance()
    {
        return _laps * LapDistanceKm * KmToMiles; // Distance in miles
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
        return $"{base.GetSummary()} Swimming";
    }
}
