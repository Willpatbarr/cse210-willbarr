using System;

public class Item
{
    private string _itemType;
    private string _name;
    private string _description;
    private List<string> _namesList = new List<string>();
    private List<string> _descriptionsList = new List<string>();
    private int _randIndex;
    private int _requiredLevel;
    private Random _rand = new Random();

    public Random GetRand()
    {
        return _rand;
    }
    public void SetRandomIndex(Random rand)
    {
        _randIndex = rand.Next(10);
    }
    public void SetNamesList(params string[] strings)
    {
        List<string> namesList = new List<string>(strings);
        _namesList = namesList;
    }
    public void SetDescriptionsList(params string[] strings)
    {
        List<string> descriptionsList = new List<string>(strings);
        _descriptionsList = descriptionsList;
    }
    public void SetName()
    {
        string name = _namesList[_randIndex];
        _name = name;
    }
    public void SetDescription()
    {
        string description = _descriptionsList[_randIndex];
        _description = description;
    }
    public void SetItemType(string type)
    {
        _itemType = type;
    }
    public void SetRequiredLevel(int level)
    {
        _requiredLevel = level;
    }
    public virtual void DisplayItemDetails()
    {
        Console.WriteLine(_itemType + "\n" + _name + "\n" + _description + "\nRequired level to equip: " + _requiredLevel);
    }
    public int GetRequiredLevel()
    {
        return _requiredLevel;
    }
    public void PrintSlowly(string sentence)
    {
        foreach (var letter in sentence)
        {
            Console.Write(letter);
            Thread.Sleep(25);
        }
    }
    public string GetName()
    {
        return _name;
    }

}