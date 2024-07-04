using System;
using System.IO;

public class Account
{
    private string _username;
    private string _saveFileName;
    private int _pointsBalance;
    private List<Goal> _goalsList = new List<Goal>();

    public Account(string username)
    {
        _username = username;
    }
    public void IncreasePointsBalance(int value)
    {
        _pointsBalance += value;
    }
    public List<Goal> GetGoalsList()
    {
        return _goalsList;
    }
    public void DisplayGoalsList()
    {
        foreach (Goal goal in _goalsList)
        {
            Console.WriteLine(goal.GetDisplayStringOf());
        }
    }
    public void AddGoal(Goal goalToAdd)
    {
        _goalsList.Add(goalToAdd);
    }
    public void SetSaveFileName(string saveFileName)
    {
        _saveFileName = saveFileName;
    }
    public void SaveFile()
    {
       using (StreamWriter writer = new StreamWriter(_saveFileName, true))
        {
            foreach (var goal in _goalsList)
            {
                writer.WriteLine(goal.GetFileStringOf());
            }
        }
    }
    public void CreateAccountFile()
    {
        if (File.Exists(_saveFileName))
        {
            Console.WriteLine($"{_saveFileName} exists");
        }
        else
        {
            using (StreamWriter writer = new StreamWriter(_saveFileName))
            {
                writer.WriteLine(_username + ":" + _pointsBalance);
            }
        }
    }
    public void LoadAccountFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"File {filename} does not exist.");
            return;
        }

        using (StreamReader reader = new StreamReader(filename))
        {
            // Load the account info
            string accountInfo = reader.ReadLine();
            var accountData = accountInfo.Split(':');
            _username = accountData[0];
            _pointsBalance = int.Parse(accountData[1]);

            // Load the goals
            
            while (!reader.EndOfStream)
            {
                string goalLine = reader.ReadLine();

                var goalData = goalLine.Split(':');
                string goalType = goalData[0];

                var goalAttributes = goalData[1].Split(',');

                Goal goal;

                if (goalType == "SimpleGoal")//order - goalName, goalDescription, goalValue, timesCompleted
                {
                    goal = new SimpleGoal(goalAttributes[0], goalAttributes[1], int.Parse(goalAttributes[2]), int.Parse(goalAttributes[3]));
                }
                else if (goalType == "EternalGoal")//order - goalName, goalDescription, goalValue, timesCompleted
                {
                    goal = new EternalGoal(goalAttributes[0], goalAttributes[1], int.Parse(goalAttributes[2]), int.Parse(goalAttributes[3]));
                }
                else if (goalType == "ChecklistGoal")//order - goalName, goalDescription, goalValue, timesCompleted, timesToComplete
                {
                    goal = new ChecklistGoal(goalAttributes[0], goalAttributes[1], int.Parse(goalAttributes[2]), int.Parse(goalAttributes[3]), int.Parse(goalAttributes[4]));
                }
                else
                {
                    goal = null;
                }


                _goalsList.Add(goal);
            }
        }
    }
    public void RecordEvent()
    {
        List<Goal> goalsList = GetGoalsList();
        DisplayGoalsList();
        Console.Write("Please enter the number of the goal you wish to record: ");
        int userInput = Convert.ToInt32(Console.ReadLine()) - 1;
        Goal recordedGoal = goalsList[userInput];
        recordedGoal.IncrementTimesCompleted();
        if (recordedGoal.IsComplete())
        {
            recordedGoal.SetCompletedStatusIcon(true);
            IncreasePointsBalance(recordedGoal.GetGoalValue());
        }
        else
        {
            recordedGoal.SetCompletedStatusIcon(false);
        }
    }

}