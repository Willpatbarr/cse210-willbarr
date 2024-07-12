using System;

public class Encounter
{
    private Player _playerCharacter;
    private Enemy _enemyCharacter;

    private Character _firstFighter;
    private Character _secondFighter;

    public Encounter(Player player)
    {
        _playerCharacter = player;
        Armor armor = new Armor();
        Weapon weapon = new Weapon();
        _enemyCharacter = new Enemy(armor, weapon);
    }

    public void StartEncounter()
    {
        PrintSlowly("As you walk down the path you hear rustling in the bushes");
        Thread.Sleep(2000);
        Console.WriteLine("...");
        Thread.Sleep(2000);
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
    public void EndEncounter()
    {

    }
    public bool Fight()
    {//returns true if the player wins and false if the player loses.
        return false;
    }
    public void WinFight()
    {

    }
    public void LoseFight()
    {

    }
    public void LootEnemy()
    {
        
    }
    public void PrintSlowly(string sentence)
    {
        foreach (var letter in sentence)
        {
            Console.Write(letter);
            Thread.Sleep(50);
        }
    }
}