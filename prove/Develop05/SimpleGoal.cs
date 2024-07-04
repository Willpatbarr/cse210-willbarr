using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string goalName, string goalDescription, int goalValue)
    {
        SetGoalName(goalName);
        SetGoalDescription(goalDescription);
        SetGoalValue(goalValue);
        SetGoalType("SimpleGoal");
        SetCompletedStatusIcon(false);
        
    }
    public SimpleGoal(string goalName, string goalDescription, int goalValue, int timesCompleted)
    {
        SetGoalName(goalName);
        SetGoalDescription(goalDescription);
        SetGoalValue(goalValue);
        SetTimesCompleted(timesCompleted);
        SetGoalType("SimpleGoal");
        SetCompletedStatusIcon(false);
    }
}