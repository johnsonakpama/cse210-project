using System IO;

DateTime theCurrentTime = DateTime.Now;
string dateText = theCurrentTime.ToshortDateString();

string fileName = "myFile.txt";

using (StreamWriter outputFile = new StreamWriter(filename))

// you can add text to the file with the writeline method

outputFile.writeline("Who was the most intresting person you interacted with today?",
"What was the best part of your day?",
"How did you see hand of the Lord in your life today?",
"What was the strongest emotion you felt today?",
"If you had one thing you could do over today, what would it be");

string filename = "myFile.txt";
{
    string[] line = System.File.ReadAllLine(Filename);

    foreach(string line in lines)
    {
        string[] part = line.split(",");
        string fileName = part = [0]; 
    }
}
public void Display()
{
    Console.WriteLine($"{_Write} {_Display} {_Load} {_Save} {_Quit}");
}
static void LoadFile()
{
    Console.WriteLine();
    // getting current entry info, setting to filename
    int saveFile = 0
    string DisplayName = ",";
    foreach(var F0 in F1.GetFile(""))
    Save file++;
    DisplayNameLength = F0.Length;
2    Console.WriteLine(saveFile.ToString() +"," + DisplayJournal);
}
string toload = Console.ReadLine();
using StreamReader string = new StreamReader(toload + "");
JournalDate.Name = string.ReadLine();

static void SaveJournals (charDate JournalDate)
{
    using(StreamWriter sw = new StreamWriter(JournalDate.Name""))
    {
        foreach{System.Reflection.Fileinfo stat in JournalDate.GetType().Getfilies()};
        sw.WriteLine(stat.GetValue(JournalDate));


    }
    sw.Close();
}