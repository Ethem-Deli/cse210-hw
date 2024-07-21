public class Event
{ 
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public string Title { get => _title; set => _title = value; }
    public string Description { get => _description; set => _description = value; }
    public string Date { get => _date; set => _date = value; }
    public string Time { get => _time; set => _time = value; }
    public Address Address { get => _address; set => _address = value; }

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"Event: {Title}\nDescription: {Description}\nDate: {Date}\nTime: {Time}\nLocation: {Address}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"{GetType().Name}: {Title} on {Date}";
    }
}
