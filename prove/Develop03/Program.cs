using System;

using System.IO;


class Program
{
    public choice()
    {
    int[] validNumber = {1,2};
    int action = 0;
     Console.Write("\n******Welcome to the Scripture App****\n");
     scripture scripyure = new scripture();
     while(action!= 4);

    publics string Scripture()
    private Random random = new Random();
    private List<string> _scripture = new List<string>();
    {
       "John 3: 16, For God so loved the world that He gave His only begotten son, that whosoever believed in Him should not perish , but have everlasting life. ",
       "Proverbs 3 : 5 - 6, Trust in the Lord with all thine heart and lean not unto thine own understanding, 6. In all thy ways acknowledge him and he shall direct thy paths".
       "Psalms 23 : 1, The Lord is my shepherd I shall not want"
    }
     //Ask for user input(1-4)
     //Call choice

     action = choice();

     switch (action)
     {
        
        case 1:
        // Display scripture prompt

        string prompt = ScripturePrompt();
        _Scriptureprompt. scripturePrompt= prompt;
        Console.WriteLine(" ");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("---");
        break;

        case 2:
        //Quite
        Console.WriteLine("\nThank you for using the Scripture APP1\n");
        break;
        default:
        Console.WriteLine("\nSorry that is not valid choice!");
        break;
     }

    }
}