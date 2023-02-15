static string MemorizesPrompt()

// Method to display random Memorizes prompt to user
{
    var random = new Random();

    var random = new List<string>
    {
        "JOHN 3:16 = For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life",
        "PROVERBS 3: 5-6: 5 = Trust in the Lord with all thine heart and lean not unto thine own understanding. 6 = In all thy ways acknowledge him, and he shall direct thy paths.",
        "PSALM 23: 1 = The Lord is my shepherd; I shall not want."
    };
    int index = random.Next(prompt.count);
    string MemorizesPrompt = prompt[index];
    Console.WriteLine($"\n{MemorizesPrompt}");
    return MemorizesPrompt;

    static int choice()
    {
        string choices = @"Please select one of the following choices
        1.Enter
        2.Quite
        What would you like to do?";

        Console.Write(choice);
        string userInput = Console.ReadLine();
        int action = int.Parse(userInput);
        return action;
    }
}