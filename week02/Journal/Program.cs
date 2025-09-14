using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class JournalEntry
{
    public DateTime Date { get; set; }
    public string Prompt { get; set; }
    public string Content { get; set; }
}

public class JournalProgram
{
    private static List<string> prompts = new List<string>
    {
        "How did I see the hand of the Lord in my life today?",
        "How did I resolve some challenges at the job site today?",
        "What I have learned from my scripture studies today?",
        "List some of your favorite quotes from the Book of Mormon:",
        "Who is your favorite speaker for today's conference?",
        "What did you learn today from the general conference?",
        "What made you smile today?",
        "What challenge did you overcome today?",
        "What are you grateful for right now?",
        "Describe a moment of peace you experienced today.",
        "What is one thing you learned today?",
        "If you could change one thing about today, what would it be?",
        "What is a goal you have for tomorrow?",
        "What emotions did you feel today and why?",
        "Describe a conversation that impacted you today.",
        "What is a small act of kindness you witnessed or performed today?"
    };

    public static void Main(string[] args)
    {
        List<JournalEntry> journalEntries = new List<JournalEntry>();

        string filename = "myJournal.csv";

        Console.WriteLine("Welcome to your Digital Journal!");

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Write a new journal entry");
            Console.WriteLine("2. View all entries (not implemented in this version)");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    JournalEntry newEntry = CreateNewEntry();
                    journalEntries.Add(newEntry);
                    SaveEntriesToCsv(journalEntries, filename);
                    Console.WriteLine("Journal entry saved successfully!");
                    break;
                case "2":
                    Console.WriteLine("Viewing entries is not yet implemented. Please check back later!");
                    break;
                case "3":
                    Console.WriteLine("Exiting journal. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static JournalEntry CreateNewEntry()
    {
        JournalEntry entry = new JournalEntry();
        entry.Date = DateTime.Now;

        Random rand = new Random();
        entry.Prompt = prompts[rand.Next(prompts.Count)];

        Console.WriteLine($"\nJournal Prompt: {entry.Prompt}");
        Console.WriteLine("Write your entry below (press Enter twice to finish):");

        string content = "";
        string line;
        while (!string.IsNullOrWhiteSpace(line = Console.ReadLine()))
        {
            content += line + Environment.NewLine;
        }
        entry.Content = content.Trim(); // Remove trailing newline if any

        return entry;
    }

    private static void SaveEntriesToCsv(List<JournalEntry> entries, string filename)
    {
        // Check if the file exists and if it's empty to write headers
        bool fileExists = File.Exists(filename);
        bool writeHeader = !fileExists || new FileInfo(filename).Length == 0;

        using (StreamWriter writer = new StreamWriter(filename, append: true)) // Append to existing file
        {
            if (writeHeader)
            {
                writer.WriteLine("Date,Prompt,Content");
            }

            foreach (var entry in entries)
            {
                // Escape commas and newlines in content to prevent CSV parsing issues
                string escapedContent = $"\"{entry.Content.Replace("\"", "\"\"").Replace(Environment.NewLine, "\\n")}\"";
                writer.WriteLine($"{entry.Date:yyyy-MM-dd HH:mm:ss},\"{entry.Prompt}\",{escapedContent}");
            }
        }
    }
}