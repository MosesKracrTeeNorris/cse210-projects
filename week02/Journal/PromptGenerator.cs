using System;
using System.Collections.Generic;

public class PromptGenerator
{
    Random random = new Random();
    public List<string> _prompts = new List<string>
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
    public string GetRandomPrompt()
    {
        int randomIndex = random.Next(_prompts.count);
        return _prompts[randomIndex];
    }
    
}