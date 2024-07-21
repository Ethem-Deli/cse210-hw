using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Video> videos = new List<Video>();

        // Create Videos
        Video video1 = new Video("Exploring the Park", "Alice Smith", 300);
        Video video2 = new Video("Tech Reviews", "Bob Johnson", 600);
        Video video3 = new Video("Cooking Tips", "Chris Brown", 400);
        Video video4 = new Video("Watching the Scenic View of the Mountain", "Nathanael Kolob", 1000);

        // Add Comments to video1
        video1.AddComment(new Comment("Jane Smith", "Great video!"));
        video1.AddComment(new Comment("John Doe", "Very informative."));
        video1.AddComment(new Comment("Emily Brown", "Loved it!"));
        video1.AddComment(new Comment("Nat Nat", "Nice to walk around"));
        video1.AddComment(new Comment("Nat Nat", "Nice to walk around"));
        video1.AddComment(new Comment("Nat Nat", "Nice to walk around"));

        // Add Comments to video2
        video2.AddComment(new Comment("Sarah Beesly", "Thanks for the review!"));
        video2.AddComment(new Comment("Michael Scott", "Helpful insights."));
        video2.AddComment(new Comment("Pam Lee", "Good job!"));
        video2.AddComment(new Comment("Joseph Lee", "Great Reviews"));

        // Add Comments to video3
        video3.AddComment(new Comment("Dwight Deli", "Nice tips."));
        video3.AddComment(new Comment("Ethem Deli", "Tried this recipe, it was delicious."));
        video3.AddComment(new Comment("Ethan Hudson", "Keep up the good work!"));
        video3.AddComment(new Comment("John Wayne", "Looks Delicious."));

        // Add Comments to video4
        video4.AddComment(new Comment("Genesis Guzman", "Love the view"));
        video4.AddComment(new Comment("Alice Wonder", "Nice place to camp"));
        video4.AddComment(new Comment("Lynn Lee", "Wow Great!!"));
        video4.AddComment(new Comment("Deli Ethem", "I want to Visit there."));
        video4.AddComment(new Comment("Nat Nat", "Nice to walk around"));
        video4.AddComment(new Comment("Nat Nat", "Nice to walk around"));

        // Add Videos to list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        // Display Video Details
        foreach (var video in videos)
        {
            video.DisplayDetails();
            Console.WriteLine();
        }
    }
}
