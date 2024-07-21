using System;

public class Axe : Weapon
{
    public Axe()
    {
        Random rand = GetRand();
        SetItemType("Weapon");
        SetWeaponType("Axe");
        SetRandomIndex(rand);
        SetNamesList("Bloodaxe", "Stormbreaker", "Ironclaw", 
        "Frostbite", "Dwarvenedge", "Soulreaver", "Warbringer", 
        "Nightfall", "Ragefang", "Thunderstrike");
        SetDescriptionsList(
"A brutal axe with a serrated blade, perfect for inflicting deep wounds and causing bleeding.",
"A mighty axe that crackles with lightning, able to unleash powerful electrical strikes.",
"A sturdy axe with a sharp iron blade, favored by warriors for its reliability in battle.",
"An icy axe that chills to the touch, capable of freezing enemies with a single strike.",
"A masterfully crafted axe by dwarves, renowned for its balance and cutting precision.",
"An eerie axe that absorbs the souls of those it kills, growing stronger with each life taken.",
"A massive axe designed for war, capable of cleaving through armor and shields effortlessly.",
"A dark axe that thrives in the shadows, granting the wielder increased power at night.",
"A savage axe with a fierce bite, enhancing the wielder's strength and fury in combat.",
"An axe imbued with the power of thunder, able to create shockwaves that stun opponents."
);
        SetName();
        SetDescription();
        SetDamagePerHit(rand.Next(1,31));
        SetAccuracy();
        SetRequiredLevel(rand.Next(11));
    }
    public Axe(int level)//creates armor at lvl = level
    {
        Random rand = GetRand();
        SetItemType("Weapon");
        SetWeaponType("Axe");
        SetRandomIndex(rand);
        SetNamesList("Bloodaxe", "Stormbreaker", "Ironclaw", 
        "Frostbite", "Dwarvenedge", "Soulreaver", "Warbringer", 
        "Nightfall", "Ragefang", "Thunderstrike");
        SetDescriptionsList(
"A brutal axe with a serrated blade, perfect for inflicting deep wounds and causing bleeding.",
"A mighty axe that crackles with lightning, able to unleash powerful electrical strikes.",
"A sturdy axe with a sharp iron blade, favored by warriors for its reliability in battle.",
"An icy axe that chills to the touch, capable of freezing enemies with a single strike.",
"A masterfully crafted axe by dwarves, renowned for its balance and cutting precision.",
"An eerie axe that absorbs the souls of those it kills, growing stronger with each life taken.",
"A massive axe designed for war, capable of cleaving through armor and shields effortlessly.",
"A dark axe that thrives in the shadows, granting the wielder increased power at night.",
"A savage axe with a fierce bite, enhancing the wielder's strength and fury in combat.",
"An axe imbued with the power of thunder, able to create shockwaves that stun opponents."
);
        SetName();
        SetDescription();
        SetDamagePerHit(level + 10);
        SetAccuracy();
        SetRequiredLevel(level);
    }
}