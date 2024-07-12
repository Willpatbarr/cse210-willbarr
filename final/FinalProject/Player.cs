using System;

public class Player : Character
{
    private int _level = 1; //goes up to level 10 for items
    private int _xpToNextLevel;
    private int _xpStore = 0;

    public Player(string name, Weapon weapon, Armor armor)
    {
        _xpToNextLevel = _level * 10;
        SetName(name);
        AddHealth(100);
        SetWeapon(weapon);
        SetArmor(armor);
    }

    public void TakeWeapon(Weapon weapon)
    {
        if (weapon.GetRequiredLevel() <= _level)
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
        if (armor.GetRequiredLevel() <= _level)
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
    }
    public void LevelUp()
    {
        _level ++;
        _xpToNextLevel += 50;
        AddHealth(50);
    }
}