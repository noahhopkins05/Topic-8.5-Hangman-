using System;

class Program
{
    static void Main(string[] args)
    {
        string[] words = { "apple", "banana", "cherry", "date", "elderberry", "fig" };
        Random random = new Random();
        string wordToGuess = words[random.Next(words.Length)];
        char[] guess = new char[wordToGuess.Length];
        for (int i = 0; i < guess.Length; i++)
        {
            guess[i] = '_';
        }

        int attemptsLeft = 6;
        bool wordGuessed = false;
        char guessChar;
        string input;

        while (!wordGuessed && attemptsLeft > 0)
        {
            Console.WriteLine("Guess the word: " + new string(guess));

            Console.Write("Enter a letter: ");
            input = Console.ReadLine().ToLower();
            guessChar = input[0];

            if (wordToGuess.Contains(guessChar))
            {
                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == guessChar)
                    {
                        guess[i] = guessChar;
                    }
                }
            }
            else
            {
                attemptsLeft--;
                Console.WriteLine("Wrong! Attempts left: " + attemptsLeft);
            }

            if (new string(guess) == wordToGuess)
            {
                wordGuessed = true;
                Console.WriteLine("Congratulations! You guessed the word: " + wordToGuess);
            }
        }

        if (!wordGuessed)
        {
            Console.WriteLine("You ran out of attempts. The word was: " + wordToGuess)
        }

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
}
