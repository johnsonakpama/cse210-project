using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
    }

    static void main(string[]args)
    {
        DisplayWelcomeMassage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = squareNumber(userNumber);

        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcomeMassage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name!");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("What is your favorite number!");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int squareNumber(int number)
    {
        int square = numuber + number;
        return square;
    }
    static void DisplayResult(String name, int number)
    (
        Console.WriteLine($"{name} the square of your number is{square}");
    )
    
         

}
