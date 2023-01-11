using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
    }


// for part 3,where we use a random number...
 randomGenerator = new Random();
 int magicNumber = randomGenerator.next(1,101);
 int guess = -1; 
 
 // we could also use a do-while loop here...

