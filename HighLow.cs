using System;
using System.Collections.Generic;

class HighLow
{
  public static void Main()
  {
    Console.WriteLine("Enter a number between 1-100");
    int userInput = int.Parse(Console.ReadLine());
    int high = 100;
    int low = 0;
    bool notCorrect = true;
    while (notCorrect)
    {
      int guess = ((high + low) / 2);
      Console.WriteLine("Did you guess " + guess + "?");
      Console.WriteLine("Was my guess too high, too low or spot on? ['high', 'low', 'correct']");
      string userHighLowCorrect = Console.ReadLine();
      if (userHighLowCorrect == "high")
      {
        high = guess;
      }
      else if (userHighLowCorrect == "low")
      {
        low = guess;
      }
      else if (userHighLowCorrect == "correct")
      {
        Console.WriteLine("Damn I'm good!");
        notCorrect = false;
      }
    }
    Console.WriteLine("Would you like to play again? [y/n]");
    string playAgain = Console.ReadLine();
    if(playAgain == "y")
    {
      Main();
    }
    else
    {
      Console.WriteLine("Goodbye");
    }
  }
}