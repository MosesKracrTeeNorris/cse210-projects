using System;

class MagicNumberGame
{
    static void Main(string[] args)
    {
        // Create a Random object to generate random numbers.
        Random random = new Random();

        // Generate a random magic number between 1 and 100 (inclusive).
        int magicNumber = random.Next(1, 101); 

        int userGuess = 0;
        int guessCount = 0;

        Console.WriteLine("Welcome to the Magic Number Guessing Game!");
        Console.WriteLine("I have chosen a number between 1 and 100. Try to guess it!");

        // Loop until the user guesses the magic number.
        while (userGuess != magicNumber)
        {
            Console.Write("What is the magic number?");
            string input = Console.ReadLine();

            // Attempt to parse the user's input to an integer.
            if (int.TryParse(input, out userGuess))
            {
                guessCount++; // Increment the guess counter for each valid attempt.

                if (userGuess < magicNumber)
                {
                    Console.WriteLine("Too low! The magic number is higher.");
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Too high! The magic number is lower.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        Console.WriteLine($"Congratulations! You guessed the magic number ({magicNumber}) in {guessCount} guesses.");
        Console.WriteLine("Do you want to continue playing the game? (Yes/No):");
        string playAgainInput = Console.ReadLine().ToLower();
        playAgain = (playAgainInput == "Yes");
        {
            while (playAgain);
            {
                Console.WriteLine("Thank you very much for playing!");
            }
        }
        
    }
}