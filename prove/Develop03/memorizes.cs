using System

class memorizes
{
private string myMemorizesFile = "my Memorizes.json"; 

public void Run()
{
    //Display Welcome();
    //Display choices();
}
private void DisplayWelcome()
{
    Console.WriteLine("\nWelcome to the Memorizes App!\n");
}
private void DisplayChoice()
{
    string choice = @"Please select one of the following choices:
    1.Enter
    2.Quite
    what would you like to do?";

    Console.WriteLine(choice);
    string userInput = Console.ReadLine();
    int action = int.Parse(userInput);
    return action;
}


}