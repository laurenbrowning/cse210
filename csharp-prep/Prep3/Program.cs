using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        int guess = 0;

        while (number != guess)
        {
            Console.WriteLine("Please guess a number between 1 and 101!");
            guess = int.Parse(Console.ReadLine());

            if (number > guess)
            {
                Console.WriteLine("Lower");
            }
            else if (number < guess)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Correct!");
            }
        }
    }
}