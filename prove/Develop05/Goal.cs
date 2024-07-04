using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

public class Goal
{
    private string _goalType;
    private string _goalName;
    private string _goalDescription;
    private int _goalValue;
    private int _timesCompleted;
    private string _completionStatusIcon;


    public virtual bool IsComplete()
    {
        if (_timesCompleted > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public void IncrementTimesCompleted()
    {
        ++ _timesCompleted;
    }
    
    //
    // Getters and Setters
    //
    public int GetTimesCompleted()
    {
        return _timesCompleted;
    }
    public virtual string GetFileStringOf()
    {
        return $"{_goalType}:{_goalName},{_goalDescription},{_goalValue},{_timesCompleted}";//insert file string format here
    }
    public virtual string GetDisplayStringOf()
    {
        return $"{_completionStatusIcon} {_goalName} ({_goalDescription})";//insert display string format here;
    }
    public void SetGoalName(string goalName)
    {
        _goalName = goalName;
    }
    public void SetGoalDescription(string goalDescription)
    {
        _goalDescription = goalDescription;
    }
    public void SetGoalValue(int goalValue)
    {
        _goalValue = goalValue;
    }
    public void SetCompletedStatusIcon(bool status)
    {
        if (status == true)
        {
            _completionStatusIcon = "[x]";
        }
        else
        {
            _completionStatusIcon = "[ ]";
        }
    }
    public void SetGoalType(string goalType)
    {
        _goalType = goalType;
    }
    public string GetGoalType()
    {
        return _goalType;
    }
    public string GetGoalName()
    {
        return _goalName;
    }
    public string GetGoalDescription()
    {
        return _goalDescription;
    }
    public int GetGoalValue()
    {
        return _goalValue;
    }
    public string GetCompletionStatusIcon()
    {
        return _completionStatusIcon;
    }
    public void SetTimesCompleted(int timesCompleted)
    {
        _timesCompleted = timesCompleted;
    }
    
}