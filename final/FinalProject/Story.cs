using System;

public class Story
{
    private string _storySaveFileName;
    private int _distanceToCastle;
    private Player _playerCharacter;

    public Story(int difficulty, string playerName)
    {
        _storySaveFileName = "";
        _distanceToCastle = difficulty * 500;
        Sword swordLVL1 = new Sword(1);
        Armor armorLVL1 = new Armor(1);
        Player player = new Player(playerName, swordLVL1, armorLVL1);
        _playerCharacter = player;
    }
    public Story(string storySaveFileName, int distanceToCastle, Player playerCharacter)
    {
        //to be added at the end of time allows
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
        PrintSlowly(sentence);
        Console.WriteLine("");
        //generate intro paragraph that details the journey to the castle
        //and includes you're stats and items
    }
    public void ReachCastle()
    {
        //generates ending paragraph to tell the player they won
    }
    public void SaveStory()
    {
        //to be added with the save and loading feature if time allows
    }
    public bool WinCheck()
    {
        return false;//checks to see if the playre has reached the castle
    }
    public void EndJourney()
    {

    }
    public void PrintSlowly(string sentence)
    {
        foreach (var letter in sentence)
        {
            Console.Write(letter);
            Thread.Sleep(25);
        }
    }
    public Player GetPlayerCharacter()
    {
        return _playerCharacter;
    }
}