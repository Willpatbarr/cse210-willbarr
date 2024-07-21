using System;
using System.Reflection.Metadata;
using System.Security.Cryptography;

// The fastest way to use almost every method made for this program 
// is to select a difficultty of 1, try to run at every fight, and 
// try to take every item dropped by the enemies.

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Please enter your name: ");
            string playerName = Console.ReadLine();
            Console.Clear();
            Console.Write("Please choose a difficulty (1-3): ");
            string difficulty;
            do
            {
                difficulty = Console.ReadLine();
                if (difficulty != "1" && difficulty != "2" && difficulty != "3")
                {
                    Console.WriteLine("Please enter a number between 1 and 3");
                }
            } while (difficulty != "1" && difficulty != "2" && difficulty != "3");
            int difficultyValue = Convert.ToInt32(difficulty);
            Console.Clear();

            Story story = new Story(difficultyValue, playerName);
            Player playerCharacter = story.GetPlayerCharacter();

            story.StartJourney();
            Console.WriteLine("press enter to continue");
            Console.ReadLine();

            while (true)
            {
                Encounter encounter = new Encounter(playerCharacter);
                Console.Clear();
                encounter.StartEncounter();
                bool skipCheck = encounter.Run();

                if (skipCheck == false)
                {
                    bool result = encounter.Fight();
                    if (result)
                    {
                        Console.Write("\nYou win\nenter to continue");
                        Console.ReadLine();
                        encounter.LootEnemy();
                        Console.Write("\nenter to continue");
                        Console.ReadLine();
                        encounter.EndEncounter(story);
                    }
                    else
                    {
                        Console.WriteLine("\nyou lose");
                        story.EndJourney();
                        break;
                    }
                }
                else
                {
                    encounter.EndEncounter(story);
                }

                bool storyStatus = story.WinCheck();
                if (storyStatus)
                {
                    Console.Clear();
                    story.ReachCastle();
                    story.EndJourney();
                    break;
                }
            }
            Console.Write("Would you like to play again?\nPress enter to play again, anything to else to quit: ");
            string input = Console.ReadLine();
            if (input != "")
            {
                break;
            }
            Console.Clear();
        }
    }
}