using System

public class JournalEntry
{

// public int_entryNumber = 0;


public string _dateTime = "";

public string _journalPrompt = "";

public string _journalEntry = "";

// public journalEntry ()
{

}
public void Display()
{
    console.writeLine($"\n{_dateTime}");
    console. writeLine($"prompt:{_journal:[journalPrompt]}");
    console.writeLine($"Entry:{journalEntry}");
}

}