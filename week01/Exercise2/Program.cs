using System;

public class GradeCalculator
{
    public static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int percent))
        {
            if (percent >= 0 && percent <= 100)
            {
                string letterGrade = GetLetterGrade(percent);
                Console.WriteLine($"Your letter grade is: {letterGrade}");
                if (percent >= 70)
            {
                Console.WriteLine("Congratulations! You passed!");
            }
            else
            {
                Console.WriteLine("We are sorry! Good luck next time!");
            }
            }
            else
            {
                Console.WriteLine("Score must be between 0 and 100.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numerical value.");
        }
    }

    public static string GetLetterGrade(int percent)
    {
        string grade = "";
        string sign = "";

        // Determine the letter grade
        if (percent >= 90)
        {
            grade = "A";
        }
        else if (percent >= 80)
        {
            grade = "B";
        }
        else if (percent >= 70)
        {
            grade = "C";
        }
        else if (percent >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }
        
        // Determine the plus/minus sign for grades A, B, C, D
        if (grade != "F")
        {
            int lastDigit = percent % 10;
            if (lastDigit >= 7 || (grade == "A" && percent == 100)) // A+ for 100
            {
                sign = "+";
            }
            else if (lastDigit <= 2)
            {
                sign = "-";
            }
        }

        return grade + sign;
    }
}