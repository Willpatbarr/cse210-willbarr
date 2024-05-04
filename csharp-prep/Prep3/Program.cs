using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 11);
        int guess;
        do{
            Console.Write("Guess a number: ");
            guess = Convert.ToInt32(Console.ReadLine());

            if (guess < number)
            {
                Console.WriteLine("Too low");
            }
            else if (guess > number)
            {
                Console.WriteLine("Too high");
            }
            else
            {
                Console.WriteLine("Correct");
            }
        }
        while (guess != number);
    }
}