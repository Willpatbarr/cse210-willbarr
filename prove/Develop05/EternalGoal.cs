using System;

public class EternalGoal : Goal
{
    public EternalGoal(string goalName, string goalDescription, int goalValue)
    {
        SetGoalName(goalName);
        SetGoalDescription(goalDescription);
        SetGoalValue(goalValue);
        SetGoalType("EternalGoal");
        SetCompletedStatusIcon(false);
    }

    public override bool IsComplete()//permanently returns false since the eternal goals cannot be completedd
    {
        return false;
    }
    public EternalGoal(string goalName, string goalDescription, int goalValue, int timesCompleted)
    {
        SetGoalName(goalName);
        SetGoalDescription(goalDescription);
        SetGoalValue(goalValue);
        SetTimesCompleted(timesCompleted);
        SetGoalType("EternalGoal");
        SetCompletedStatusIcon(false);
    }
}