using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        ReflectionActivity reflectionActivity = new ReflectionActivity();
        ListingActivity listingActivity = new ListingActivity();

        Console.WriteLine("Welcome, which activity would you like to do?\nBreathing (1)\nReflecting (2)\nListing (3)\nQuit (4)");
        
        int activityCounter = 0;

        while (true)
        {
            Console.Write(": ");
            string choice = Console.ReadLine();
            
            if (choice == "1")
            {
                breathingActivity.RunActivity();
                activityCounter++;
            }
            else if (choice == "2")
            {
                reflectionActivity.RunActivity();
                activityCounter++;
            }
            else if (choice == "3")
            {
                listingActivity.RunActivity();
                activityCounter++;
            }
            else if (choice == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a valid choice");
            }
        }

        Console.WriteLine($"{activityCounter} activities were completed!");

    }
}