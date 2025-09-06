using System;

class Program
{
   static void Main(string[] args)
        {
        Random randomGenerator = new Random();

        int MagicNumber = randomGenerator.Next(1, 100);

        int userGuess = 0;
        int guessCount = 0;


        while (userGuess != MagicNumber)
       {
           Console.WriteLine("What is the magic number? ");
           userGuess = int.Parse(Console.ReadLine());
           if (MagicNumber > guess)
           {
               Console.WriteLine("Higher");
           }
           else if (MagicNumber < guess)
           {
                Console.WriteLine("Lower");
           }
           else
           {
            Console.WriteLine("Yes! You have guessed the number.");
           }

        } 
    }


}
