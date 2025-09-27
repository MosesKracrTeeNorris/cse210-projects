public class Entry
{
    public string _date;
    public string _promptText;
    public string _entriesText;
    public string _method; //Prompts user to save based on the method
    public string _time; // Used to record date and time journal is saved.

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine($"Method: {_method}");
    }
}