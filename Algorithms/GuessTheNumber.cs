namespace Algorithms
{
    class GuessTheNumber

    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int targetNumber = random.Next(1, 101); // Generate a random number between 1 and 100
            int guess;
            int attempts = 0;
            bool correctGuess = false;

            Console.WriteLine("Welcome to the Number Guessing Game!");
            Console.WriteLine("I have picked a number between 1 and 100. Try to guess it.");

            while (!correctGuess)
            {
                Console.Write("Enter your guess: ");
                if (int.TryParse(Console.ReadLine(), out guess))
                {
                    attempts++;

                    if (guess == targetNumber)
                    {
                        correctGuess = true;
                        Console.WriteLine("Congratulations! You guessed the correct number in " + attempts + " attempts.");
                    }
                    else if (guess < targetNumber)
                    {
                        Console.WriteLine("The number is higher. Try again.");
                    }
                    else
                    {
                        Console.WriteLine("The number is lower. Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            Console.ReadLine();
        }
    }

}

}
