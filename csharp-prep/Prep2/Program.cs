using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Enter your grade percentage: ");
        int grade;
        grade = Convert.ToInt32(Console.ReadLine());

        string letter;
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (grade > 70)
        {
            Console.WriteLine("Congrats you passed");
        }
        else
        {
            Console.WriteLine("You didn't pass");
        }

        Console.WriteLine($"Your letter grade is {letter}");
    }
}