using System;

public class Program
{ 
    public static void Main()
    {
        Address address = new Address("456 Elm St", "Anycity", "TX", "US");

        Event lecture = new Lecture("Science Lecture", "A lecture on quantum physics", "2024-08-01", "10:00 AM", address, "Dr. Smith", 100);
        Event reception = new Reception("Wedding Reception", "A celebration of marriage", "2024-08-05", "6:00 PM", address, "rsvp@wedding.com");
        Event outdoorGathering = new OutdoorGathering("Music Festival", "A day of live music", "2024-08-10", "12:00 PM", address, "Sunny, 25°C");

        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine(outdoorGathering.GetShortDescription());
    }
}
