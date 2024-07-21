public class Lecture : Event
{ 
    public string SpeakerName { get; set; }
    public int Capacity { get; set; }

    public Lecture(string title, string description, string date, string time, Address address, string speakerName, int capacity)
        : base(title, description, date, time, address)
    {
        SpeakerName = speakerName;
        Capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nType: Lecture\nSpeaker: {SpeakerName}\nCapacity: {Capacity}";
    }

    public override string GetShortDescription()
    {
        return $"Lecture: {Title} on {Date}";
    }
}
