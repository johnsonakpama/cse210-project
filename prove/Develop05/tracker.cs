using System;

class GoalTracker
{
    public class GetUserInput
    {
        public void MainMenu()
        {
            bool UserGoal = false;
            while(userGoal == false)
            {
                Console.WriteLine("\nMain Menu");
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("Enter 6 to exixt Application");
                Console.WriteLine("Enter 1 to Create New Goal");
                Console.WriteLine("Enter 2 to List Goals");
                Console.WriteLine("Enter 3 to Save Goals");
                Console.WriteLine("Enter 4 to Load Goals");
                Console.WriteLine("Enter 5 to Record Event");
                string commandInput = Console.ReadLine();
            }
        }
    }
    public void GoalTypes()
    {
        if(userInput == 1)
        Console.WriteLine("Select a choice from the menu");
        Console.WriteLine("Which type of goal would you like to create?");
        Console.WriteLine("What is the name of your Goal?");
        Console.WriteLine("What is the short descrition of it?");
        Console.WriteLine("What is the amount of points associated with this goal?");
        Console.WriteLine("How many times dose the goal need to be accomplished for a bonus?");
    }
}