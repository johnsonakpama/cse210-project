using System;
public class EternalQuest
{
  privaten List<Goal> _goal = new List<Goal>();

  public void AddGoal (Goal goal)
  {
    _goal. Add(goal);
    Console. WriteLine($"Added goal:{goal Name}");
  }

public void RecordEvent(string name)
{
  foreach (Goal goal in _goal)
  {
    if (goal.Name == name)
    {
      goal.RecordEvent();
      return ;
    }
    Console.WriteLine($"Goal not vaild: {name}");
  }
  
}
public void DisplayStatus()
{
  int totalPoints = 0;
  Console.WriteLine("Current Goals:");

  foreach(Goal goal in _goal)
  {
    Console.WriteLine(goals.GetStatus());
    totalPoints += goal.points;
  }
  Console.WriteLine($"Total points: {totalPoints}");
}
}

