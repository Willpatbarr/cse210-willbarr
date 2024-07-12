using System;

public class Armor : Item
{
    private int _defense;
    private int _weight;

    public Armor()
    {
        Random rand = GetRand();
        SetItemType("Armor");
        SetRandomIndex(rand);
        SetNamesList("Ironhelm", "Dragonscale", "Shadowmail", 
        "Kingsguard", "Elvencloak", "Stoneplate", "Windweave", 
        "Doombringer", "Frostguard", "Phoenix");
        SetDescriptionsList("A sturdy helmet forged from iron, offering excellent protection for the head while maintaining a balance between defense and weight.",
"Armor crafted from dragon scales, known for its incredible strength and resistance to both physical attacks and magical spells.",
"Lightweight chainmail infused with shadow magic, enhancing stealth and agility, allowing the wearer to move silently and swiftly.",
"Ornate armor worn by royal bodyguards, providing superior defense and a regal appearance, symbolizing loyalty and honor.",
"A finely woven cloak of elven silk, granting increased speed, resistance to magic, and the ability to blend into natural surroundings.",
"Heavy armor made from enchanted stone, offering unmatched protection but reducing mobility, ideal for steadfast warriors.",
"Armor made from woven air and enchanted fabrics, allowing for incredible lightness and agility, perfect for swift and nimble fighters.",
"Dark armor cursed with ancient magic, increasing the wearer’s power but slowly corrupting their soul and mind.",
"Armor imbued with the essence of ice, providing excellent defense against fire and heat, and slightly enhancing cold-based attacks.",
"Armor that regenerates itself, infused with the essence of a phoenix, offering continuous protection and a second chance in battle."
);
        SetName();
        SetDescription();
        SetRequiredLevel(rand.Next(11));
        _defense = rand.Next(6);
        _weight = rand.Next(21);
    }
    public Armor(int level)//creates armor at lvl = level
    {
        Random rand = GetRand();
        SetItemType("Armor");
        SetRandomIndex(rand);
        SetNamesList("Ironhelm", "Dragonscale", "Shadowmail", 
        "Kingsguard", "Elvencloak", "Stoneplate", "Windweave", 
        "Doombringer", "Frostguard", "Phoenix");
        SetDescriptionsList("A sturdy helmet forged from iron, offering excellent protection for the head while maintaining a balance between defense and weight.",
"Armor crafted from dragon scales, known for its incredible strength and resistance to both physical attacks and magical spells.",
"Lightweight chainmail infused with shadow magic, enhancing stealth and agility, allowing the wearer to move silently and swiftly.",
"Ornate armor worn by royal bodyguards, providing superior defense and a regal appearance, symbolizing loyalty and honor.",
"A finely woven cloak of elven silk, granting increased speed, resistance to magic, and the ability to blend into natural surroundings.",
"Heavy armor made from enchanted stone, offering unmatched protection but reducing mobility, ideal for steadfast warriors.",
"Armor made from woven air and enchanted fabrics, allowing for incredible lightness and agility, perfect for swift and nimble fighters.",
"Dark armor cursed with ancient magic, increasing the wearer’s power but slowly corrupting their soul and mind.",
"Armor imbued with the essence of ice, providing excellent defense against fire and heat, and slightly enhancing cold-based attacks.",
"Armor that regenerates itself, infused with the essence of a phoenix, offering continuous protection and a second chance in battle."
);
        SetName();
        SetDescription();
        SetRequiredLevel(level);
        _defense = level;
        _weight = level + 5;
    }

    public int DefendDamage(int rawDamage)
    {
        int refinedDamage = rawDamage - _defense;
        return refinedDamage;
    }
    public int GetDefense()
    {
        return _defense;
    }
    public int GetWeight()
    {
        return _weight;
    }

}