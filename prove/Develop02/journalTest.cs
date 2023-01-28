using System

class journalTest
{
    private string myjournalFile = "my journal.json"

    public void Run()
    {
        //Display Welcome();

        //Display Choice();
    }
    private void DisplayWelcome()
    {
        console.write("\nwelcome to the journal App!\n");
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

        console.writeLine(choice);
        string userInput = console.ReadLine();
        int action = int.parse(userInput);
        
        return action
    }
    private void createJournalFile()
    {
      if(!file.Exist(myjournalFile))

      file.create(myjournalFile);  
    }
}