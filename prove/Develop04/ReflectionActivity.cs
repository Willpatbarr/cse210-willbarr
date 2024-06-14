using System;

public class ReflectionActivity : Activity
{
    private List<string> _promptList;
    private List<string> _questionList;

    public ReflectionActivity()
    {
        SetActivityName("Reflection Activity");
        SetActivityDescription("This activity will help you reflect on times in your life\nwhen you have shown strength and resilience. This will help\nyou recognize the power you have and how you can use it in\nother aspects of your life.");
        _promptList = new List<string> {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."};
        _questionList = new List<string> {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",};
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
    public void UserInputsAnswers()
    {
        Console.Write(": ");
        Console.ReadLine();
    }
    public void RunActivity()
    {
        DisplayStartMessage();
        StartInput();
        Timer(GetActivityDuration());

        while (DateTime.Now < GetActivityEndTime())
        {
            string randomPrompt = GetRandomItem(_promptList);
            string randomQuestion = GetRandomItem(_promptList);
            DisplayText(randomPrompt);
            DisplayText(randomQuestion);
            UserInputsAnswers();
            PauseWithSpinner(3000);
        }

        DisplayEndMessage();
    }
}