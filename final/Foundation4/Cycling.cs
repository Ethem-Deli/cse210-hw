public class Cycling : Activity
{
    private float _speed; // Speed in km/h

    public Cycling(string date, int length, float speed)
        : base(date, length)
    {
        _speed = speed;
    }

    public override float GetDistance()
    {
        return _speed * 0.62f * (GetLength() / 60.0f); // Convert km to miles
    }

    public override float GetSpeed()
    {
        return _speed * 0.62f; // Convert km/h to mph
    }

    public override float GetPace()
    {
        return 60 / GetSpeed(); // Pace in minutes per mile
    }

    public override string GetSummary()
    {
        return $"{base.GetSummary()} Cycling";
    }
}
