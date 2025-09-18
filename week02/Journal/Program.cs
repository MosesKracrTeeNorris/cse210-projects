using System;
using System.Collections.Generic;
using System.IO;

public class JournalEntry
{
    private static string filename = Console.ReadLine();
    private static List<string> _journalEntries = new List<string>();
    private static Random _random = new Random();

    private static string[] _prompts = new string[]
    {
        "What was the most interesting thing that happened today?",
        "What are you grateful for right now?",
        "Describe a challenge you faced and how you overcame it.",
        "What is a goal you are working towards?",
        "If you could give advice to your past self, what would it be?"
    };

    public static void Main(string[] args)
    {
        LoadJournalFromFile(); // Load existing entries on startup
        RunMenu();
        Console.WriteLine("Welcome to the journal program!");
    }

    private static void RunMenu()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    ViewAllEntries();
                    break;
                case "3":
                    LoadJournalFromFile();
                    break;
                case "4":
                    SaveJournalToFile();
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private static void WriteNewEntry()
    {
        string prompt = _prompts[_random.Next(_prompts.Length)];
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("Your entry: ");
        string entry = Console.ReadLine();
        _journalEntries.Add($"{DateTime.Now}: {entry}");
        Console.WriteLine("Entry added successfully!");
    }

    private static void DisplayAllEntries()
    {
        if (_journalEntries.Count == 0)
        {
            Console.WriteLine("\nNo entries to display.");
            return;
        }

        Console.WriteLine("\n--- Your Journal Entries ---");
        foreach (string entry in _journalEntries)
        {
            Console.WriteLine(entry);
        }
    }

    private static void LoadJournalFromFile()
    {
        if (File.Exists(filename))
        {
            try
            {
                _journalEntries.Clear(); // Clear current entries before loading
                string[] lines = File.ReadAllLines(filename);
                _journalEntries.AddRange(lines);
                Console.WriteLine($"\nJournal loaded from {filename} successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading journal: {ex.Message}");
            }
        }
        else
        {
            Console.WriteLine($"\nJournal file {filename} not found. Starting with an empty journal.");
        }
    }

    private static void SaveJournalToFile()
    {
        try
        {
            File.WriteAllLines(filename, _journalEntries);
            Console.WriteLine($"\nJournal saved to {filename} successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }
}