using System;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;

public class MagicalStaff : Weapon
{
    private Player _user;
    
    public MagicalStaff(Player user)
    {
        SetItemType("Weapon");
        SetWeaponType("Magical Staff");
        SetName("Magical Wizard Staff");
        SetDescription("A glowing magical staff that grows in power as the wielder does");
        SetDamagePerHit(10);
        SetRequiredLevel(5);
        _user = user;
    }
    public override int DealDamage()
    {
        int modifier = _user.GetLevel();
        Console.WriteLine("Wooshy woosh...");
        Console.WriteLine($"Hit! {GetDamage() * modifier} dealt");
        return GetDamage() * modifier;
    }
}