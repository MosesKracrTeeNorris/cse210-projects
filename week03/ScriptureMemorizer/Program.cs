using System;
using System.Collections.Generic;

public class ScriptureMemorizer
{
    public static void Main(string[] args)
    {
        List<string> scriptures = new List<string>
        { 
            "2 Nephi 2:9 - Wherefore, he is the firstfruits unto God, inasmuch as he shall make intercession for all the children of men; and they that believe in him shall be saved.",
            "2 Nephi 2:6 - Wherefore, redemption cometh in and through the Holy Messiah; for he is full of grace and truth.",
            "John 3:16 - For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.",
            "Proverbs 3:5-6 - Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.",
            "Philippians 4:13 - I can do all things through Christ which strengtheneth me.",
            "Matthew 6:33 - But seek ye first the kingdom of God, and his righteousness; and all these things shall be added unto you."
        };

        Random random = new Random();
        string userInput = "";

        foreach (string a in Scripture) 
   {
        string newList = a.Replace(HideRandomWords, "_");
        Console.Write(newList);
        Console.Write(" ");
    }

        while (userInput.ToLower() != "quit")
        {
            Console.Clear();
            int randomIndex = random.Next(0, scriptures.Count);
            string currentScripture = scriptures[randomIndex];
            Console.WriteLine(currentScripture);
            Console.WriteLine("\nPress Enter to continue or type 'quit' to finish.");

            userInput = Console.ReadLine();
        }

        Console.WriteLine("Thanks for the memorizer!");
    }
}  