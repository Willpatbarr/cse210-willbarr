using System;

public class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _activityDuration; //in miliseconds
    private DateTime _activityEndTime;
    private int _pauseDuration;
    private string _startMessage;
    private string _endMessage;

    public Activity()
    {
        _endMessage = "Thankyou for taking the time to be mindful, have a wonderful day!";
        _pauseDuration = 0;
    }

    public void Timer(int duration)
    {
        DateTime startTime = DateTime.Now;
        _activityEndTime = startTime.AddSeconds(duration);
    }
    public void DisplayStartMessage()
    {
        Console.WriteLine($"{_activityName}");
        Console.WriteLine($"{_activityDescription}");
    }
    public void StartInput()
    {
        Console.Write("How long would you like to\ndo this activity for?: ");
        _activityDuration = Convert.ToInt32(Console.ReadLine());
    }
    public void DisplayEndMessage()
    {
        Console.WriteLine(_endMessage);
    }
    public void PauseWithSpinner(int pauseDuration)
    {
        int cycles = pauseDuration / 500;
        int counter = 0;
        while (cycles != counter)
        {
            Console.Write("-");

            Thread.Sleep(125);

            Console.Write("\b \b");
            Console.Write("+");

            Thread.Sleep(125);

            Console.Write("\b \b");
            Console.Write("|");

            Thread.Sleep(125);

            Console.Write("\b \b");
            Console.Write("+");

            Thread.Sleep(125);
            Console.Write("\b \b");
            
            counter++;
        }
    }
    public void PauseWithCountDown(int pauseDuration)
    {
        int displayNumber = pauseDuration;
        while (displayNumber >= 0)
        {
            Console.Write($"{displayNumber/1000}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            displayNumber-= 1000;
        }
    }
    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }
    public void SetActivityDescription(string activityDescription)
    {
        _activityDescription = activityDescription;
    }
    public void SetPauseDuration(int pauseDuration)
    {
        _pauseDuration = pauseDuration;
    }
    public int GetPauseDuration()
    {
        return _pauseDuration;
    }
    public int GetActivityDuration()
    {
        return _activityDuration;
    }
    public void SetStartMessage(string startMessage)
    {
        _startMessage = startMessage;
    }
    public DateTime GetActivityEndTime()
    {
        return _activityEndTime;
    }
}
