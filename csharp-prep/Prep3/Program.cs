using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Console.WriteLine("Guess My Number Game");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11); // Generates a number between 1 and 10

        Console.Write("What is the magic number (between 1 and 10)? ");
        int guess = int.Parse(Console.ReadLine());

        while (guess != number)
        {
            if (guess > number)
            {
                Console.WriteLine("Lower ");
                guess = int.Parse(Console.ReadLine());
            }
            else if (guess < number)
            {
                Console.WriteLine("Higher ");
                guess = int.Parse(Console.ReadLine());
            }
        }
        Console.WriteLine("Congratulations! You've guessed the magic number!");
    }
}