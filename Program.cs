using System;

namespace guessing_game
{
  class Program
  {
    //static int calculate(int upper, int lower)
    //{
    //   return ((upper + lower) / 2);
    //
    //  }
    static void Main(string[] args)
    {
      var upper = 100;
      var lower = 1;
      var number = 50;
      var guesses = 1;
      var guessing = true;

      Console.WriteLine("Press Enter to start Number Guesser");
      var enter = Console.ReadKey();
      if (enter.Key == ConsoleKey.Enter)
      {
        Console.WriteLine("Think of a number between 1 and 100 and I will guess it");
        while (guessing == true)
        {
          Console.WriteLine("'Higher' or 'Lower' than " + number + "? Type 'You guessed it' if I guessed it!");
          var hint = Console.ReadLine();

          if (hint == "Higher")
          {
            lower = number + 1;
          }
          else if (hint == "Lower")
          {
            upper = number - 1;
          }
          else if (hint == "You guessed it")
          {
            guessing = false;
            Console.WriteLine("I guessed " + number + " in " + guesses + " tries!");
            Console.WriteLine("Press Space to try again!");
            var tryAgain = Console.ReadKey();
            if (tryAgain.Key == ConsoleKey.Spacebar)
            {
              guessing = true;
              number = 50;
              guesses = 0;
              upper = 100;
              lower = 1;
            }
          }
          number = ((upper + lower) / 2);
          guesses++;
        }


      }
    }
  }
}
