using System;
using System.Collections.Generic;
using System.IO;

public class JournalProgram
{
    static void Main(string[] args)
    {
       Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following options:\n");
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool run = true;

    while (run)
    {
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display journal");
        Console.WriteLine("3. Save journal");
        Console.WriteLine("4. Load journal ");
        Console.WriteLine("5. Quit");
        Console.WriteLine("Choose an option: ");
        string choice = Console.ReadLine();
        Console.WriteLine();

        switch (choice)
        {
           case "1":
                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._time = DateTime.Now.ToShortTimeString();  
                newEntry._promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {newEntry._promptText}");
                Console.Write("Your response: ");
                newEntry._entryText = Console.ReadLine();
                Console.Write("Your method today: ");

                newEntry._method = Console.ReadLine();
                journal.AddEntry(newEntry);
                Console.WriteLine();
                break;
            case "2":
                journal.DisplayAll();
                break;

            case "3":
                Console.Write("Enter the filename to save: ");
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);
                Console.WriteLine("Journal saved successfully!\n");
                break;
            case "4":
                    Console.Write("Enter the filename to load: ");
                    string loadFile = Console.ReadLine();
                    journal.LoadFromFile(loadFile);
                    Console.WriteLine("Journal loaded successfully!\n");
                    break;

                case "5":
                    run = false;
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
            default:
                Console.WriteLine("Invalid choice. Try again.\n");
                break;
        }
     }
  }
}