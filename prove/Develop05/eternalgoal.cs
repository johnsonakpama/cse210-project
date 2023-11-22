using System;

using System. Collection.Geneeric;

public class EternalGoal : Goal
{
    private int _count = 0;

    public EternalGoal(string name, int points) : base(name, points)
    {}

public override string GetStatus()
{
    return $"{_count} x {Name}";
}
}