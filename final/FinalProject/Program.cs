using System;

class Program
{
    static void Main(string[] args)
    {
        // Axe axeTest = new Axe();
        // Armor armorTest = new Armor();
        // Enemy enemyTest = new Enemy(armorTest, axeTest);
        // enemyTest.Spawn();
        Console.Write("Please enter your name: ");
        string playerName = Console.ReadLine();
        Console.Clear();
        Console.Write("Please choose a difficulty (1-10): ");
        int difficulty = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        Story story = new Story(difficulty, playerName);
        Player playerCharacter = story.GetPlayerCharacter();

        story.StartJourney();
        Console.WriteLine("press enter to continue");
        Console.ReadLine();

        bool playerStatus = true;//changes to false if the player dies or wins

        while (playerStatus)
        {
            Encounter encounter = new Encounter(playerCharacter);
            encounter.StartEncounter();
            bool result = encounter.Fight();
            if (result)
            {
                encounter.WinFight();
                encounter.LootEnemy();
            }
            else
            {
                encounter.LoseFight();
                story.EndJourney();
            }

        }



    }
}