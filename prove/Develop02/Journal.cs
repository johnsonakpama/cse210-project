using System,

public class journal
{
    public List<JournalEntry>Journal = new List<JournalEntry>();

    public journal()
    {

    

    public journal Void Display()
    {

    }
    console.writeLine("\n****journal Entries****");

    foreach (JournalEntry journal in journal)
    {
        journal.Display();
    }

    
    }    
    
}