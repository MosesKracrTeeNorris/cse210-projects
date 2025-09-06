using System;
class program
{
   static void Main(string[] args)
   {
    DisplayWelcomeMessage();

    string userName = PromptUserName();
    int squaredNumber = squaredNumber(userNumber);
    DisplayResult(userName, squareNumber);

   }
   static void DisplayWelcomeMessage()
   {
    Console.WriteLine("Please enter your name:");
    string name = Console.ReadLine();

    return name;
   }
   static int SquareNumber(int number)
   {
    int square = number * number;
    return square;
   }
   static void DisplayResult(string name, int square)
   {

       Console.WriteLine($"{name}, the square of your number is {square}");
   }

}