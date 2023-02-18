using System;

class Program
{
    static void Main(string[] args)
    
    // Create a base "Assignment" Object

    Assignment a1 = new Assignment("Samuel Ben","Multipulication");
    Console.WriteLine (a1.GetSummary());

    // Now creat the derived class assignments

    MathAsignment a2 = new MathAsignment("Roberto Rodi","Fraction","7 - 3", "8 - 19");
    Console.WriteLine(a2.GetSummary());
    Console.WriteLine(a2._GetHomeworkList());
    
    WriteAssignment a3 = new WriteAssignment("Mary Jacob","European History","The cause of the worlr war 11");
    Console.WriteLine(a3.GetSummary());
    Console.WriteLine(a3.GetWritingInformation());
}