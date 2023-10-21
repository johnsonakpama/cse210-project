using System;

class word()
{ 
   private string myWord = "myWord";
   _Word : string;
   _Hidden : bool;
// Method to display random words prompt to user

    var random = new Random();

    var word = new List<string>
    {
        "JOHN 3:16 = For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life",
        "PROVERBS 3: 5-6: 5 = Trust in the Lord with all thine heart and lean not unto thine own understanding. 6 = In all thy ways acknowledge him, and he shall direct thy paths.",
        "PSALM 23: 1 = The Lord is my shepherd; I shall not want."
    };
    int index = random.Next(prompt.count);
    string wordPrompt = prompt[index];
    Console.WriteLine($"\n{wordPrompt}");
    return wordPrompt;

    public void Run()
    {
        1 _Hide
        2 _Reveal
        3 _Is hidden
        4 _GetRenderText
    }


    static int choice()
    {
        string choices = @"Please select one of the following choices";
        Console.write("press 'Enter' to hide more word, type 'Reveal' to reveal a word or type 'quit' to finish");

        Console.Write(choice);
        string userInput = Console.ReadLine();
        int action = int.Parse(userInput);
        return action;
    }
}