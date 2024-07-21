using System;
using System.Runtime.CompilerServices;

public class Encounter
{
    private Player _playerCharacter;
    private Enemy _enemyCharacter;

    private Character _firstFighter;
    private Character _secondFighter;
    private int _encounterDistance;

    public Encounter(Player player)
    {
        Random rand = new Random();
        _playerCharacter = player;
        Armor armor = new Armor();
        Weapon weapon;
        int weaponType = rand.Next(1,8);
        if (weaponType == 1 || weaponType == 2 || weaponType == 3)
        {
            weapon = new Sword();
        }
        else if (weaponType == 4 || weaponType == 5 || weaponType == 6)
        {
            weapon = new Axe();
        }
        else
        {
            weapon = new MagicalStaff(_playerCharacter);
        }
        _enemyCharacter = new Enemy(armor, weapon);
        _encounterDistance = rand.Next(150,351);
    }

    public void StartEncounter()
    {
        Console.WriteLine("As you walk down the path you hear rustling in the bushes");
        Console.WriteLine("...");
        _enemyCharacter.Spawn();
    }
    public void DetermineTurnOrder()
    {
        int enemyWeight = _enemyCharacter.GetWeight();
        int playerWeight = _playerCharacter.GetWeight();
        if (enemyWeight > playerWeight)
        {
            _firstFighter = _playerCharacter;
            _secondFighter = _enemyCharacter;
        }
        else
        {
            _firstFighter = _enemyCharacter;
            _secondFighter = _playerCharacter;
        }
    }
    public void EndEncounter(Story story)
    {
        story.ApproachCastle(_encounterDistance);
        Console.WriteLine(story.GetDistanceToCastle() + " meters remain\nenter to continue");
        Console.ReadLine();
    }
    public bool Fight()
    {//returns true if the player wins and false if the player loses.
        Character winner = _playerCharacter;
        DetermineTurnOrder();

        Console.Clear();
        while (true)
        {
            _secondFighter.TakeDamage(_firstFighter.Attack());
            Console.WriteLine("");
            if (_secondFighter.HealthCheck() == false)
            {
                winner = _firstFighter;
                break;
            }

            _firstFighter.TakeDamage(_secondFighter.Attack());
            Console.WriteLine("");
            if (_firstFighter.HealthCheck() == false)
            {
                winner = _secondFighter;
                break;
            }
            
        }

        if (winner == _playerCharacter)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void LootEnemy()
    {
        Console.Clear();
        _playerCharacter.GainXp(_enemyCharacter.GetXpWorth());

        Weapon enemyWeapon = _enemyCharacter.GetWeapon();
        Armor enemyArmor = _enemyCharacter.GetArmor();

        // runs to prompt the player to take the weapon of the enemy
        _playerCharacter.ShowWeapon();
        Console.Write($"""
        Would you like to take this weapon?:
        name : {enemyWeapon.GetName()}
        type : {enemyWeapon.GetWeaponType()}
        Damage : {enemyWeapon.GetDamage()}
        required level : {enemyWeapon.GetRequiredLevel()}
        (y/n): 
        """);
        string menuChoice;
        do
        {
            menuChoice = Console.ReadLine();
            if (menuChoice != "y" && menuChoice != "n")
            {
                Console.WriteLine("Please enter a valid response: ");
            }
        } while (menuChoice != "y" && menuChoice != "n");

        if (menuChoice == "y")
        {
            _playerCharacter.TakeWeapon(enemyWeapon);
        }
        else if (menuChoice == "n")
        {
            Console.WriteLine("Weapon was left behind");
        }

        Console.WriteLine("");
        //runs through the next bit to take armor from enemy
        _playerCharacter.ShowArmor();
        Console.Write($"""
        Would you like to take this armor?:
        name : {enemyArmor.GetName()}
        weight : {enemyArmor.GetWeight()}
        defense : {enemyArmor.GetDefense()}
        required level : {enemyArmor.GetRequiredLevel()}
        (y/n): 
        """);
        do
        {
            menuChoice = Console.ReadLine();
            if (menuChoice != "y" && menuChoice != "n")
            {
                Console.WriteLine("Please enter a valid response: ");
            }
        } while (menuChoice != "y" && menuChoice != "n");

        if (menuChoice == "y")
        {
            _playerCharacter.TakeArmor(enemyArmor);
        }
        else if (menuChoice == "n")
        {
            Console.WriteLine("Armor was left behind");
        }
    }
    public bool Run()
    {
        Console.Write("would you like to run or fight? (r/f): ");

        string menuChoice;
        do
        {
            menuChoice = Console.ReadLine();
            if (menuChoice != "r" && menuChoice != "f")
            {
                Console.WriteLine("Please enter a valid response (r or f): ");
            }
        } while (menuChoice != "r" && menuChoice != "f");

        if (menuChoice == "f")
        {
            return false;
        }
        else
        {
            //runs a check for a random value to be above 60to be able to esape, armor weight is subtracted from chance value.
            Random rand = new Random();
            int runCheck = rand.Next(101) - _playerCharacter.GetArmor().GetWeight();
            if (runCheck <= 60)
            {
                Console.WriteLine("\nYou were unable to get away safely." + "\n" + "You are forced to fight");
                Console.WriteLine("enter to continue");
                Console.ReadLine();
                return false;
            }
            else
            {
                Console.WriteLine("\nYou were able to get away safely");
                Console.WriteLine("enter to continue");
                Console.ReadLine();
                return true;
            }
        }
    }
    
}