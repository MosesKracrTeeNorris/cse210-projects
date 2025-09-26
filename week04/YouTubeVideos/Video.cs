using System.Collections.Generic; // Required for using List

public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>(); // Initialize the list of comments
    }

    // Method to add a comment to the video's list
    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }

    // Method to get all comments
    public List<Comment> GetComments()
    {
        return _comments;
    }

    // Method to get the number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds");
        Console.WriteLine($"Comments ({GetNumberOfComments()}):");
        foreach (var comment in _comments)
        {
            comment.Display();
        }
        Console.WriteLine();
    }
}