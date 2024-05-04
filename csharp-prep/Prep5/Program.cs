using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program");
        }
        static string PromptUserName()
        {
            string username;
            Console.Write("What is your username?: ");
            username = Console.ReadLine();
            return username;
        }
        static int PromptUserNumber()
        {
            int UserNumber;
            Console.Write("What is favorite number?: ");
            UserNumber = Convert.ToInt32(Console.ReadLine());
            return UserNumber;
        }
        static int SquareNumber(int number)
        {
            int NumberSquared;
            NumberSquared = number * number;
            return NumberSquared;
        }
        static void DisplayResult()
        {
            string username = PromptUserName();
            int number = SquareNumber(PromptUserNumber());
            Console.WriteLine($"{username}, the square of your number is {number}");
        }
        DisplayResult();
    }
}