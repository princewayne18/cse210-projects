using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);
        int counter = 0;
        int guess;

        do
        {
            Console.Write("What is your guess? ");
            string answer = Console.ReadLine();
            guess = int.Parse(answer);
            counter++;

            if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < number)
            {
                Console.WriteLine("higher");
            }

        } while (guess != number);
        Console.WriteLine($"You guessed it!! It took you {counter} guesses.");

    }
}

