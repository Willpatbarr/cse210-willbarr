using System;

public class Enemy : Character
{
    private int _xpWorth;
    private string _description;
    private List<string> _namesList = new List<string>
    {
        "Nightshade", "Fireborn", "Frostwolf", 
        "Stormrider", "Bloodfiend", "Shadowspawn", 
        "Rockbeast", "Venomfang", "Soulreaper", 
        "Dreadknight",
    };
    private List<string> _descriptionsList = new List<string>
    {
"A sinister creature of the night, shrouded in darkness and capable of poisoning its prey.",
"A fiery demon emerges from the depths of hell, engulfing everything in flames.",
"A savage wolf covered in frost, hunting in packs and freezing its enemies with icy breath.",
"A spectral rider on a ghostly steed, commanding storms and striking with lightning speed.",
"A vampiric fiend that feeds on blood, growing stronger and more vicious with each victim.",
"A shadowy being born of darkness, able to blend into shadows and strike without warning.",
"A monstrous beast of living stone, impervious to most attacks and crushing foes with its might.",
"A serpent with venomous fangs, whose bite delivers a deadly poison that spreads quickly.",
"A wraith-like entity that harvests souls, draining the life force of those who cross its path.",
"A fearsome knight clad in dark armor, wielding a cursed blade that brings doom to its foes."
    };

    public Enemy(Armor armor, Weapon weapon)
    {
        Random rand = new Random();
        int randIndex = rand.Next(10);
        SetName(_namesList[randIndex]);
        _description = _descriptionsList[randIndex];
        SetArmor(armor);
        SetWeapon(weapon);
        AddHealth(rand.Next(20,101));
        _xpWorth = (GetHealth() - 80) * 2;
        SetLevel(rand.Next(1,11));
    }

    public void Spawn()
    {//generates an intro paragraph to the next enemy to spawn
        string sentence1 = ($""" 
        {_description}, 
        you encounter an enemy {GetName()}:
        health : {GetHealth()}
        Armor : {GetArmor().GetName()}
            Defense : {GetArmor().GetDefense()}
        Weapon : {GetWeapon().GetName()} ({GetWeapon().GetWeaponType()})
            Damage : {GetWeapon().GetDamage()}
        """);
        Console.WriteLine(sentence1);
        Console.WriteLine();
    }
    public int GetXpWorth()
    {
        return _xpWorth;
    }

}