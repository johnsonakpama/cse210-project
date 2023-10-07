using System IO;

class Program
{
    static void main(string[]args)
}
DateTime theCurrentTime = DateTime.Now;
string dateText = theCurrentTime.ToshortDateString();

using (StreamWriter outputFile = new StreamWriter(filename))

// you can add text to the file with the writeline method
public List<Entry>entries = new List<Entry>();

activityFile.writeline("Who was the most intresting person you interacted with today?",
"What was the best part of your day?",
"How did you see hand of the Lord in your life today?",
"What was the strongest emotion you felt today?",
"If you had one thing you could do over today, what would it be");

Journal journal = new Journal();
string choice = "0";do
{
    Console.WriteLine("Please make a choice from the following option");
    Console.WriteLine("1. Write");
    Console.WriteLine("2. Display");
    Console.WriteLine("3. Load");
    Console.WriteLine("4. Save");
    Console.WriteLine("5. Quit");

    Console.WriteLine("What would you like to do ?");
    Choice = Console.ReadLine(); if (choice =="1"){join.AddEntry();}
    if(choice =="2"){journal.Display();}
    if(choice =="3"){journal.LoadFile();}
    if(choice =="4"){journal.SaveFile();}
    While(choice != "5");
}


public void Display()
{
    Console.WriteLine($"{_Write} {_Display} {_Load} {_Save} {_Quit}");
}
 public static void LoadFile()
{
    string toload = console.ReadLine();
    using (StreamReader string = new StreamReader(toload +""));
    JournalDate.name = string.ReadLine();
}
public static void SaveToFile(List<journals>Record)
{
    Console.WriteLine("Saving to file...")
    string filename = "activity.txt";
    using (StreamWriter outputFile = StreamWriter(filename))
    foreach (Journal.journal in journals)
    {
        outputFile.WriteLine();
    }
}


