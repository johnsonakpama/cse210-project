using System;

using System.IO;


class Program
{
    static void Main(string[] args)
    {
    int[] validNumber = {1,2,3,4};
    int action = 0;
     Console.Write("\n******Welcome to the Scripyure App****\n");
     scripture scripyure = new scripture();
     while(action!= 4);
     //Ask for user input(1-4)
     //Call choice

     action = choice();

     switch (action)
     {
        
        case 1:
        // Display scripture prompt

        string prompt = ScripturePrompt();
        Scriptureprompt. ScripturePrompt= prompt;
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