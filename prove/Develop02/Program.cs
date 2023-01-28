using System;

using System.IO;

class Program
{
    static void Main(string[] args)
    {
    int []validNumber = {1,2,3,4,5};

    int action = 0;

    console.write ("\n*******Welcome to the Journal App*******\n");

    Journal journal = new Journal();

    while (action !=5)

    // Ask for user input(1-9)
    // call choice

    action = choice();

    switch (action)
    {
        case 1:

        //write journal Entry

        string dateTime = GetDateTime();

        string prompt = JournalPrompt();
        journalEntry.entry = new JournalEntry();

        entry. _dateTime dateInfo;

        entry. _journalPrompt = prompt;

        console.write(">>";)

        string userEntry = console.ReadLine();

        entry._journal.Add(entry);

        break;

        case 2:
        // Display journal Entries

        journal.Display();

        // console.writeLine("success choice 2!");

        break:
        
        case 3:

        // Load

        // console. writeLine("success choice 3!");

        break;

        case 4:

        // Save
        creat journalFile();

        // string AddEntry = journal.Display();
        // AddJournalEntry(AddEntry);
        // console.writeLine("success choice 4!");

        break;

        case 5

        // Quit

        console.writeLine("\nThank you for using the journal App!\n");

        break;

        default:
        
        console.writeLine("\nSorry that is not valid choice!");
        }
    


    
    }


    
}