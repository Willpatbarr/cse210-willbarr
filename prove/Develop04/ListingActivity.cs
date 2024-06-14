using System;

public class ListingActivity : Activity
{
    private List<string> _promptList;
    private string _listedItems;

    public ListingActivity()
    {
        SetActivityName("Listing Activity");
        SetActivityDescription("This activity will help you reflect on the good things in\nyour life by having you list as many things as you can\nin a certain area.");
        _promptList = new List<string> {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"};
    }

    public string GetRandomItem(List<string> itemList)
    {
        Random random = new Random();
        int index = random.Next(itemList.Count);
        return itemList[index];
    }
    public void DisplayText(string text)
    {
        Console.WriteLine(text);
    }
    public string UserListsItems()
    {
        Console.Write("- ");
        string item = Console.ReadLine();
        return item;
    }
    public void AddItemToString(string item)
    {
        _listedItems += $"\n{item}";
    }
    public void DisplayListedItems()
    {
        Console.WriteLine(_listedItems);
    }
    public void RunActivity()
    {
        DisplayStartMessage();
        StartInput();
        Timer(GetActivityDuration());
        PauseWithCountDown(5);

        while (DateTime.Now < GetActivityEndTime())
        {
            string randomPrompt = GetRandomItem(_promptList);
            DisplayText(randomPrompt);
            AddItemToString(UserListsItems());
        }

        DisplayListedItems();
        DisplayEndMessage();
    }
}