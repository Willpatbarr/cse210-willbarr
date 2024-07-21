using System;

public class Character
{
    private string _name;
    private int _health = 0;
    private Weapon _weapon;
    private Armor _armor;
    private int _level = 1;

    public virtual int Attack()
    {
        Console.WriteLine("Enemy turn");
        return _weapon.DealDamage();
    }
    public void TakeDamage(int damage)
    {
        _health -= _armor.DefendDamage(damage);
    }
    public bool HealthCheck()
    { //returns true if the character is still alive and false if the character is dead
        if (_health > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void SetWeapon(Weapon weapon)
    {
        _weapon = weapon;
    }
    public void SetArmor(Armor armor)
    {
        _armor = armor;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public void AddHealth(int health)
    {
        _health += health;
    }
    public int GetHealth()
    {
        return _health;
    }
    public string GetName()
    {
        return _name;
    }
    // public void PrintSlowly(string sentence)
    // {
    //     foreach (var letter in sentence)
    //     {
    //         Console.Write(letter);
    //         Thread.Sleep(25);
    //     }
    // }
    public Armor GetArmor()
    {
        return _armor;
    }
    public Weapon GetWeapon()
    {
        return _weapon;
    }
    public int GetWeight()
    {
        return _armor.GetWeight();
    }
    public int GetLevel()
    {
        return _level;
    }
    public void SetLevel(int level)
    {
        _level = level;
    }
}