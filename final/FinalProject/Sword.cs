using System;

public class Sword : Weapon
{
    public Sword()
    {
        Random rand = GetRand();
        SetItemType("Weapon");
        SetWeaponType("Sword");
        SetRandomIndex(rand);
        SetNamesList("Shadowfang", "Blazewind", "Frostblade", 
        "Dragonslayer", "Moonlight", "Starfire", "Thunderedge", 
        "Bloodreaver", "Kingsbane", "Sunstrike");
        SetDescriptionsList("A sleek sword imbued with dark magic, perfect for stealthy assassinations and quick strikes.",
"A fiery sword that burns with the intensity of a blazing inferno, scorching enemies with every hit.",
"A chilling sword that freezes anything it touches, ideal for slowing down foes in battle.",
"A legendary sword designed to defeat dragons, known for its immense power and sharpness.",
"A mystical sword that glows with a soft, lunar light, enhancing the wielder's agility and grace.",
"A radiant sword that blazes with starfire, able to cut through the toughest defenses.",
"A sword that crackles with thunder, delivering electrifying strikes that can paralyze opponents.",
"A cursed sword that drains the blood of its victims, growing more powerful with each kill.",
"A deadly sword that was used to slay kings, feared for its lethal precision and speed.",
"A brilliant sword that shines with the power of the sun, blinding enemies with its radiant light."
);
        SetName();
        SetDescription();
        SetDamagePerHit(rand.Next(11));
        SetHitsPerAttack(3);
        SetAccuracy();
        SetRequiredLevel(rand.Next(11));
    }
    public Sword(int level)//creates armor at lvl = level
    {
        Random rand = GetRand();
        SetItemType("Weapon");
        SetWeaponType("Sword");
        SetRandomIndex(rand);
        SetNamesList("Shadowfang", "Blazewind", "Frostblade", 
        "Dragonslayer", "Moonlight", "Starfire", "Thunderedge", 
        "Bloodreaver", "Kingsbane", "Sunstrike");
        SetDescriptionsList("A sleek sword imbued with dark magic, perfect for stealthy assassinations and quick strikes.",
"A fiery sword that burns with the intensity of a blazing inferno, scorching enemies with every hit.",
"A chilling sword that freezes anything it touches, ideal for slowing down foes in battle.",
"A legendary sword designed to defeat dragons, known for its immense power and sharpness.",
"A mystical sword that glows with a soft, lunar light, enhancing the wielder's agility and grace.",
"A radiant sword that blazes with starfire, able to cut through the toughest defenses.",
"A sword that crackles with thunder, delivering electrifying strikes that can paralyze opponents.",
"A cursed sword that drains the blood of its victims, growing more powerful with each kill.",
"A deadly sword that was used to slay kings, feared for its lethal precision and speed.",
"A brilliant sword that shines with the power of the sun, blinding enemies with its radiant light."
);
        SetName();
        SetDescription();
        SetDamagePerHit(level + 5);
        SetHitsPerAttack(3);
        SetAccuracy();
        SetRequiredLevel(level);

    }
}