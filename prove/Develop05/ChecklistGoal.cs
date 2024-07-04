using System;

public class ChecklistGoal : Goal
{
    private int _timesToComplete;

    public ChecklistGoal(int timesToComplete, string goalName, string goalDescription, int goalValue)
    {
        _timesToComplete = timesToComplete;
        SetGoalName(goalName);
        SetGoalDescription(goalDescription);
        SetGoalValue(goalValue);
        SetGoalType("ChecklistGoal");
        SetCompletedStatusIcon(false);
    }
    public ChecklistGoal(string goalName, string goalDescription, int goalValue, int timesCompleted, int timesToComplete)
    {
        _timesToComplete = timesToComplete;
        SetGoalName(goalName);
        SetGoalDescription(goalDescription);
        SetGoalValue(goalValue);
        SetTimesCompleted(timesCompleted);
        SetGoalType("ChecklistGoal");
        SetCompletedStatusIcon(false);
    }

    public override bool IsComplete()
    {
        if (GetTimesCompleted() == _timesToComplete)
        {
            return true;
        }
        else 
        {
            return false;
        }
    }
    public override string GetFileStringOf()
    {
        return $"{GetGoalType()}:{GetGoalName()},{GetGoalDescription()},{GetGoalValue()},{GetTimesCompleted()},{_timesToComplete}";//insert file string format here
    }
    public override string GetDisplayStringOf()
    {
        return $"{GetCompletionStatusIcon()} {GetGoalName()}: ({GetGoalDescription()}) {GetTimesCompleted()}/{_timesToComplete}";//insert display string format here;
    }
}