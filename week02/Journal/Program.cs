using System;
using System.Collections.Generic;
using System.IO;

public class JournalProgram
{
    private static List<string> prompts = new List<string>
    {
        "What was the most interesting thing that happened today?",
        "What are you grateful for right now?",
        "Describe a challenge you faced today and how you handled it.",
        "What is one thing you learned today?",
        "If you could change one thing about today, what would it be?"
    };

    public static void Main(string[] args)
    {
        while (true)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteNewEntry();
                    break;
                case "2":
                    DisplayEntries();
                    break;
                case "3":
                    SaveJournalToFile();
                    break;
                case "4":
                    LoadJournalFromFile();
                    break;
                case "5":
                    Console.WriteLine("Exiting journal program. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    private static void DisplayMenu()
    {
        Console.WriteLine("Journal Program Menu:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display all entries");
        Console.WriteLine("3. Save journal to file");
        Console.WriteLine("4. Load journal from file");
        Console.WriteLine("5. Quit");
        Console.Write("Enter your choice: ");
    }

    private static void WriteNewEntry()
    {
        Random rand = new Random();
        string randomPrompt = prompts[rand.Next(prompts.Count)];

        Console.WriteLine($"\nPrompt: {randomPrompt}");
        Console.Write("Your entry: ");
        string entryContent = Console.ReadLine();

        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        string fullEntry = $"Date/Time: {timestamp}\nPrompt: {randomPrompt}\nEntry: {entryContent}\n";

        Console.WriteLine("\nYour entry has been recorded:");
        Console.WriteLine(fullEntry);

        
    }

    private static void DisplayEntries()
    {
        Console.WriteLine("\nDisplaying all entries (Not implemented in this basic example for in-memory storage).");
        Console.WriteLine("To see saved entries, load from a file after saving.");
    }

    private static void SaveJournalToFile()
    {
        Console.Write("Enter filename to save");
        string filename = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(filename))
        {
            Console.WriteLine("Filename cannot be empty.");
            return;
        }

        else
        {
            
            string filename = $"Date/Time: {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}\nPrompt: "{randomPrompt}"\nEntry: "{entryContent};
            File.AppendAllText(filename, filename);
            Console.WriteLine($"Journal saved to {filename}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    private static void LoadJournalFromFile()
    {
        Console.Write("Enter filename to load");
        string filename = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(filename))
        {
            Console.WriteLine("Filename cannot be empty.");
            return;
        }

        try
        {
            if (File.Exists(filename))
            {
                string content = File.ReadAllText(filename);
                Console.WriteLine($"\nJournal loaded from {filename}:\n");
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }
}