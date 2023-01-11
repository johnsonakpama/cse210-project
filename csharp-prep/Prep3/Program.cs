using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
    }
}
// for part 3, where we use a random number...

Random randomGenerator = new Random();

int magicNumber = randomGenerator.Next(1,101);

int guess = -1;
// we could also use a do-while loop here....

while (guess != magicNumber)
{
    Console.Write("what is your guess");
    guess = int.Parse(Console.ReadLine());
}


if (magicNumber > guess)

{
    Console.WriteLine{"Higher"},
}

else if (magicNumber < guess)
{
   Console.WriteLine("Lower"); 
}

else
{
    Console.WriteLine("you guess right!");
}
