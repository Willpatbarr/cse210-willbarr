using System;

public class Player : Character
{
    private int _xpToNextLevel;
    private int _xpStore = 0;

    public Player(string name, Weapon weapon, Armor armor)
    {
        _xpToNextLevel = GetLevel() * 10;
        SetName(name);
        AddHealth(85);
        SetWeapon(weapon);
        SetArmor(armor);
    }

    public void TakeWeapon(Weapon weapon)
    {
        if (weapon.GetRequiredLevel() <= GetLevel())
        {
            SetWeapon(weapon);
            Console.WriteLine("Weapon Succesfully equipped!");
        }
        else
        {
            Console.WriteLine("You are not high enough level to equip this weapon");
        }
    }
    public void TakeArmor(Armor armor)
    {
        if (armor.GetRequiredLevel() <= GetLevel())
        {
            SetArmor(armor);
            Console.WriteLine("Armor succesfully equipped!");
        }
        else
        {
            Console.WriteLine("You are not high enough level to equip this armor");
        }
    }
    public void GainXp(int xpToGain)
    {
        _xpStore += xpToGain;
        while (_xpStore >= _xpToNextLevel)
        {
            _xpStore -= _xpToNextLevel;
            LevelUp();
        }
        Console.WriteLine($"You are now level {GetLevel()}");
    }
    public void LevelUp()
    {
        int level = GetLevel();
        level ++;
        SetLevel(level);
        _xpToNextLevel += 50;
        AddHealth(50);
    }
    public override int Attack()
    {
        Console.WriteLine("Your turn!");
        return GetWeapon().DealDamage();
    }
    public void ShowWeapon()
    {
        Console.WriteLine($"""
        Your Weapon
        type : {GetWeapon().GetType()}
        damage : {GetWeapon().GetDamage()}

        """);
    }
    public void ShowArmor()
    {
        Console.WriteLine($"""
        Your Armor
        weight : {GetArmor().GetWeight()}
        defense : {GetArmor().GetDefense()}

        """);
    }
}