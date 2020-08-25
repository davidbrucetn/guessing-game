using System;
using System.Collections.Generic;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {

            bool gameResult = DoYouWantToPlayAGame();
            if (gameResult)
            {
                Console.WriteLine("Great Job! You must be psychic!");
            }
            else
            {
                Console.WriteLine("Sorry you didn't win! Connection Terminated!");
            }

        }

        static Boolean DoYouWantToPlayAGame()
        {
            Console.WriteLine("Greetings, Professor Falken...");
            Console.WriteLine("Let's play a guessing game!");
            int numTries = DifficultyLevel();
            bool cheater = false;
            if (numTries == 100)
            {
                cheater = true;
                Console.WriteLine($"You get as many attempts as you like, cheater!");
            }
            else
            {
                Console.WriteLine($"You get {numTries} attempts");
            }

            int secretNumber = GetSecretNumber();
            bool winner = false;
            int numGuesses = 0;
            while ((numGuesses < numTries && !winner && !cheater) || (cheater && !winner))
            {
                int guessNumber = GuessANumber();
                if (guessNumber != secretNumber)
                {

                    Console.WriteLine($"Your guess ({guessNumber})");
                    if (guessNumber < secretNumber)
                    {
                        Console.WriteLine("Hint: Your guess was too low");
                    }
                    else
                    {
                        Console.WriteLine("Hint: Your guess was too high");
                    }
                    Console.WriteLine("Sorry! Wrong Number!");
                    if (!cheater)
                    {
                        Console.WriteLine($"You have {numTries-numGuesses-1} guesses left..");
                        numGuesses++;
                        if (numGuesses == numTries)
                        {
                            Console.WriteLine("You've used up four guesses! Game over, man! Game over! ");
                            Console.WriteLine($"The secret number was {secretNumber}");
                        }
                    }
                }
                else
                {
                    winner = true;
                    Console.WriteLine("Yay! The number is no longer a secret!");
                }
            }
            return winner;
        }

        static int GetSecretNumber()
        {
            int secretNumber = new Random().Next(1, 101);
            return secretNumber;
        }
        static int GuessANumber()
        {
            Console.Write("Guess the secret number?: ");
            string answer = Console.ReadLine().ToLower();

            // While answer is not y or n, keep asking AskTheMoose
            while (TestNumber(answer) == false)
            {
                Console.Write("Guess the secret number? (It must be a whole number!): ");
                answer = Console.ReadLine().ToLower();
            }

            int answerNumeric = Int32.Parse(answer);
            return answerNumeric;

        }
        static Boolean TestNumber(string testNumberValue)
        {
            return int.TryParse(testNumberValue, out int numberValue);
        }

        static int DifficultyLevel()
        {
            List<string> levels = new List<string>()
            {
                "easy",
                "medium",
                "hard",
                "cheater"
            };
            PresentLevels();
            string diffLevel = Console.ReadLine().ToLower();
            while (!levels.Contains(diffLevel))
            {
                PresentLevels();
                diffLevel = Console.ReadLine().ToLower();
            };
            switch (diffLevel)
            {
                case "easy":
                    return 8;
                case "medium":
                    return 6;
                case "hard":
                    return 4;
                default:
                    return 100;

            };
        }

        static void PresentLevels()
        {
            Console.WriteLine("Enter a difficulty level from the following:");
            Console.WriteLine("Easy: 8 guesses ");
            Console.WriteLine("Medium: 6 guesses ");
            Console.WriteLine("Hard: 4 guesses ");
            Console.WriteLine("Cheater: guess until you get it right ");
        }

    }

}