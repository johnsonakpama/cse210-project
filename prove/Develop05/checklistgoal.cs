using System;

using System.Collection.Geneeric;

public class ChecklistGoal : Goal
{
    private int _count = 0;
    private int _targetCount;

    public ChecklistGoal(string name, int points, int targetCount) : base(name, points)
    {
        _targetCount = targetCount;
    }
public override void RecordEvent()
{
    _count ++;
    console.WriteLine($"Recorded progress on goal {name} +{points} point")
};  
    if(_count == _targetCount)
    {
        points += 500;
        Console.WriteLine({_count}/{_targetCount} times:{Name})
    }

}