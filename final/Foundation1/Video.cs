using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    private List<Comment> _comments;
    
    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        _comments = new List<Comment>();
    }
    
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
    
    public void DisplayDetails()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
        foreach (var comment in _comments)
        {
            Console.WriteLine($"{comment.CommenterName}: {comment.CommentText}");
        }
    }
}