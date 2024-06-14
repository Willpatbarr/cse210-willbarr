using System;

public class BreathingActivity : Activity
{
    private int _inDuration;
    private int _outDuration;
    private int _cycles;
    private int _counter;

    public BreathingActivity()
    {
        SetActivityName("Beathing Activity");
        SetActivityDescription("This activity will help you relax by walking your\nthrough breathing in and out slowly. Clear your mind\nand focus on your breathing.");
        // SetStartMessage(startMessage);
        _inDuration = 4000;
        _outDuration = 6000;
    }

    public void DisplayBreatheIn(int inDuration)
    {
        Console.WriteLine("Breathe in... ");
        PauseWithCountDown(inDuration);
    }
    public void DisplayBreatheOut(int outDuration)
    {
        Console.WriteLine("Breathe out... ");
        PauseWithCountDown(outDuration);
    }
    public void CalculateCycles(int activityDuration, int inDuration, int outDuration) //activity duration is in miliseconds
    {
        int cycleTime = (inDuration + outDuration);
        _cycles = activityDuration / cycleTime;
    }
    public void CalculatePauseDuration(int activityDuration, int inDuration, int outDuration)
    {
        int cycleTime = (inDuration + outDuration);
        SetPauseDuration(activityDuration % cycleTime);
    }
    public void RunActivity()
    {
        DisplayStartMessage();

        StartInput();

        CalculateCycles(GetActivityDuration(), _inDuration, _outDuration);
        CalculatePauseDuration(GetActivityDuration(), _inDuration, _outDuration);

        while (_counter < _cycles)
        {
            DisplayBreatheIn(_inDuration);
            DisplayBreatheOut(_outDuration);

            _counter ++;
        }

        PauseWithSpinner(GetPauseDuration());

        DisplayEndMessage();

    }
}