using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("18 Jul 2024", 30, 5),
            new Running("21 Jul 2024", 45, 10),
            new Cycling("19 Jul 2024", 60, 20),
            new Cycling("22 Jul 2024", 90, 25),
            new Swimming("20 Jul 2024", 45, 30),
            new Swimming("23 Jul 2024", 60, 40)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
