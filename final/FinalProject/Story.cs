using System;

public class Story
{
    private int _distanceToCastle;
    private Player _playerCharacter;

    public Story(int difficulty, string playerName)
    {
        _distanceToCastle = difficulty * 500;
        Sword swordLVL1 = new Sword(1);
        Armor armorLVL1 = new Armor(1);
        Player player = new Player(playerName, swordLVL1, armorLVL1);
        _playerCharacter = player;
    }

    public void StartJourney()
    {
        string sentence = $"""
        Great knight, {_playerCharacter.GetName()}
        You have been summoned back to the castle to fortify its defenses.
        A great number of enemies to the kingdom have been seen in the 
        forest surrounding the castle and all citizens of the kingdom
        have taken refuge within the castle walls to ensure their safety.
        You must find your way to the castle in order to lend assistance,
        slay what you must.

        (you look up from the scroll and head down the path to the castle)
        
        ({_distanceToCastle} meters remain)
        """;
        Console.WriteLine(sentence);
        Console.WriteLine("");
        //generate intro paragraph that details the journey to the castle
        //and includes you're stats and items
    }
    public void ReachCastle()
    {
        Console.WriteLine("\nCongratulations!\nYou have reached the castle and can now\nhelp to reinforce it against evil");
    }
    public bool WinCheck()
    {
        if (_distanceToCastle > 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    public void EndJourney()
    {
        Console.WriteLine("\nYour journey has ended...");
    }
    public Player GetPlayerCharacter()
    {
        return _playerCharacter;
    }
    public void ApproachCastle(int distance)
    {
        _distanceToCastle -= distance;
    }
    public int GetDistanceToCastle()
    {
        return _distanceToCastle;
    }
}