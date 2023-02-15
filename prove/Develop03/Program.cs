using System;

using System.IO;


class Program
{
    static void Main(string[] args)
    {
    int[] validNumber = {1,2};
    int action = 0;
     Console.Write("\n******Welcome to the Memorizes App****\n");
     memorizes memorizes = new memorizes();
     while(action!=2);
     //Ask for user input(1-2)
     //Call choice

     action = choice();

     switch (action)
     {
        
        case 1:
        // Display memorizes prompt

        string prompt = MemorizesPrompt();
        Memorizesprompt.MemorizesPrompt= prompt;
        Console.WriteLine("");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("---");
        break;

        case 2:
        //Quite
        Console.WriteLine("\nThank you for using the Memorizes APP1\n");
        break;
        default:
        Console.WriteLine("\nSorry that is not valid choice!");
        break;
     }

    }
}