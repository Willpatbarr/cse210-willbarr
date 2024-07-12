using System;
using System.Security.Cryptography.X509Certificates;

public class Weapon : Item
{
    private string _weaponType;
    private int _damagePerHit;
    private int _hitsPerAttack;
    private int _accuracy = 5;

    public void SetAccuracy()
    {
        _accuracy = GetRand().Next(11);
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
    public int DealDamage()
    {
        int totalDamage = 0;
        for (int i = 0; i < _hitsPerAttack; i++)
        {
            Console.WriteLine("Swing...");
            Thread.Sleep(2000);
            if (AccuracyCheck())
            {
                Console.WriteLine("Hit!");
                totalDamage += _damagePerHit;
            }
            else 
            {
                Console.WriteLine("Oh no! Miss!");
            }
        }
        return totalDamage;
    }
    public void SetDamagePerHit(int damage)
    {
        _damagePerHit = damage;
    }
    public void SetHitsPerAttack(int hits)
    {
        _hitsPerAttack = hits;
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
        return _damagePerHit;
    }

}