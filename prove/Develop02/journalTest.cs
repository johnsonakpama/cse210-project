using System;

class journalTest
{
    private string myjournalFile = "my journal.json";

    public void Run()
    {
        //Display Welcome();

        //Display Choice();
    }
    private void DisplayWelcome()
    {
        Console.Write("\nwelcome to the journal App!\n");
    }
    private void DisplayChoice()
    {
        string choice = @"please select one of the following choice:
        1. Write
        2. Display
        3. Load
        4. Save
        5. Quit
        What would you like to do?";

        Console.WriteLine(choice);
        string userInput = Console.ReadLine();
        int action = int.Parse(userInput);
        return action;
    }
    private void createJournalFile()
    {
      if(!File.Exist(myjournalFile));

      File.Create(myjournalFile);  
    }
}