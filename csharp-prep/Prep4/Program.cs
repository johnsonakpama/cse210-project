using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
    }
}

List<int> number = new List<int>();

// please not we could use a do-while loop here...

int userNumber = -1;

while (userNumber != 0)
{
    Console.Write("enter a number(0 to quit):");
    string userResponse = Console.ReadLine();
    userNumber = int.Parse(userResponse);

// only add the number to the list if it is not 0

if (userNumber != 0)
 
    {
        number.Add(userNumber);
    }
}

// part 1 : compute the sun...
int sum = 0;

foreach (int number in numbers)
{
    sum += number;
    Console.WriteLine($"The sum is:{sum}");
}

// Part 2 : compute the average
// Notice that we first cast the sum variable to be a float, otherwise because
// both the sum and the count are interger the compute will do interger division
// and i will not get a decimal value/even  thoughit put the into a float variable

float average = ((float)sum)/ numbers.count;
{
    Console.WriteLine($"The average is:{average}");
}

// part 3 find the max
int max = numbers[0];

foreach (int number in numbers)
{
    if ( number > max)
    {
    // This number is greater than the max  we have found the new max...

    max = number;
    }

    Console.WriteLine($"the max is:{max}");
}