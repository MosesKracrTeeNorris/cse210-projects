using System;

class Program
{
   static void Main(string[] args)
        {
        Random randomGenerator = new Random();

        //int MagicNumber = randomGenerator.Next(1, 88);

        int guess = Console.ReadLine();

        while (guess != MagicNumber)
       {
           Console.WriteLine("What is the magic number? ");
           guess = int.Parse(Console.ReadLine());
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
              Console.WriteLine("You guessed it!");
           }

        } 
    }


}
