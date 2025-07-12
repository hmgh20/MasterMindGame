using System;

class Program
{
    static void Main(string[] args)
    {
        string? code = null;
       int attempts = 10;


     for (int i = 0; i < args.Length; i++)
      {
         if (args[i] == "-c" && i + 1 < args.Length)
          code = args[i + 1];
         if (args[i] == "-t" && i + 1 < args.Length && int.TryParse(args[i + 1], out int parsed))
            attempts = parsed;
      }

  MasterGame game = new MasterGame(code, attempts);
        
        bool won = false;

        Console.WriteLine("Welcome to Mastermind!");
        Console.WriteLine("Guess the 4 digits code (digits 1 to 8).");

        while (game.GetCurrentAttempts() < game.GetMaxAttempt())
        {
            Console.Write($"\nAttempt {game.GetCurrentAttempts() + 1}: ");
            string? guess = Console.ReadLine();

         if (string.IsNullOrEmpty(guess) || guess.Length != 4 || !int.TryParse(guess, out _))
         {
             Console.WriteLine("Invalid input. Enter 4 digits (1 to 8).");
             continue;
         }

            game.IncrementAttempts();
            if (game.IsCorrectGuess(guess))
            {
                won = true;
                break;
            }

            var (right, wrong) = game.ChecktheGuess(guess);
            Console.WriteLine($"WellPlaced: {right} |  Misplaced: {wrong}");
        }

        if (won)
        {
            Console.WriteLine("\n You cracked the code!");
        }
        else
        {
            Console.WriteLine($"\n Out of attempts! The code was: {game.GetSecretCode()}");
        }
    }
}