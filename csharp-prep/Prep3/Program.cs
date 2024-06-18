using System;

class GuessingGame
{
    static void Main()
    {
        // Stretch Challenge: Keep track of guesses and offer to play again

        bool playAgain = true;
        Random random = new Random();

        while (playAgain)
        {
            // Generates a random number between 1 and 100
            int magicNumber = random.Next(1, 101);
            // Initialize guess to a value that cannot be the magic number
            int guess = -1;
            // Counts of the guesses
            int guessCount = 0;

            // Loop until the guess matches the magic number
            while (guess != magicNumber)
            {
                // Get the user's guess
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                // Provide feedback on the guess
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it in {guessCount} guesses!");
                }
            }

            // Ask if the user wants to play again if yes game start again if user choose no then the game end.
            Console.Write("Do you want to play again? (yes/no): ");
            string response = Console.ReadLine().ToLower();
            playAgain = response == "yes";
        }
    }
}
