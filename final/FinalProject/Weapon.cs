using System;
using System.Security.Cryptography.X509Certificates;

public class Weapon : Item
{
    private string _weaponType;
    private int _damage;
    private int _accuracy = 5;

    public void SetAccuracy()
    {
        _accuracy = GetRand().Next(11);
    }
    public void SetAccuracy(int accuracy)
    {
        _accuracy = accuracy;
    }
    public bool AccuracyCheck()
    {
        int hitCheck = GetRand().Next(11);
        if (_accuracy >= hitCheck)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public virtual int DealDamage()
    {
        int totalDamage = 0;
            Console.WriteLine("Swing...");
            if (AccuracyCheck())
            {
                Console.WriteLine($"Hit! {_damage} dealt");
                totalDamage += _damage;
            }
            else 
            {
                Console.WriteLine("Oh no! Miss!");
            }
        return totalDamage;
    }
    public void SetDamagePerHit(int damage)
    {
        _damage = damage;
    }
    public void SetWeaponType(string type)
    {
        _weaponType = type;
    }
    public string GetWeaponType()
    {
        return _weaponType;
    }
    public int GetDamage()
    {
        return _damage;
    }

}