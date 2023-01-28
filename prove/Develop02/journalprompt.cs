using System

static string JournalPrompt()
// method to display random journal prompt to use
{
    var random = new Random();
    
    var random = new List<string>
    {
        "How did you show love to someone today?",
        "What do you need the most right now?",
        "What do I need to let go of today?",
        "What went well today",
        "How would you describe your spirituality today?",
        "Which country wwil you love to travel to?",
        "What is that one thing you distest?",
        "What is your favorite color?",
        "How much time did you spent on your study today?",
        "What is your favorite Tv program?"

    };
    int index = random.Next(prompt.count);
    string JournalPrompt = prompt[index];
    console.writeLine = ("\n{journalPrompt}");

    return journalPrompt;

    static int Choice()
    {
        string choices = @"Please select one of the following choice
        1. Write
        2. Display
        3. Load
        4. Save
        5. Quit
        What would you like to do?";
    }

    console.write(Choice);

    string userInput = console,ReadLine();

    int acton = int.parse(userInput);
    
    return action;

    static string GetDateTime()

    // method to get the Date and Time for journal record
    {
        DateTime now = DateTime.now;

        string currentDateTime = now Tostring("f");

        //console .writeLine(now.Tostring("f"));
        //Display Monday, Apirl 03,2023 8:00:00Am

        return currentDateTime;
    
    }
    static void createJournalFile()
    //method to check if the txt file is create if not create one
    
    string myjournalFile = "myjournal.txt";
    
    if(! file Exist.(myjournalFile));
    {
        file CreateText(myjournal);
    }
    static void AddjournalEntry()
    //method to add entry to textfile
    {
        string myjournalFile = "myjournal.txt";
        file.AppendAllText(myjournalFile"");
    }
}