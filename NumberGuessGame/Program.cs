using System;

namespace NumberGuessGame;

class NumberguessGame
{
    static void Main(String[] args)
    {
        bool playAgain = true;
        Random randomNumber = new Random();
        int guesses;
        int numberOfGuesses;
        int min = 1;
        int max = 100;
        int number;
        String response;

        while (playAgain)
        {
            number = randomNumber.Next(min, max + 1);
            numberOfGuesses = 0;
            guesses = 0;
            response = "";

            while (guesses != number)
            {
                Console.Write("Guess a number between 1 and 100: ");
                guesses = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Guess " + guesses);

                if (guesses > number)
                {
                    Console.WriteLine("Number is to high");
                }
                else if (guesses < number)
                {
                    Console.WriteLine("Number is too low");
                }
                else
                {
                    Console.WriteLine("Congrats! you guessed right!");
                    Console.WriteLine("Number of guesses: " + numberOfGuesses);
                    Console.Write("Would you like to play again? Y/N: ");
                    response = Console.ReadLine().ToUpper();

                    if (response == "Y")
                    {
                        playAgain = true;
                    }
                    else if (response == "N")
                    {
                        playAgain = false;
                    }
                }

                numberOfGuesses++;

            }
        }

        Console.WriteLine("Thanks for playing.");

        Console.ReadLine();
    }
}