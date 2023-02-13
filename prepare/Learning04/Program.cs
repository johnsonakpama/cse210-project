using System;

class Program
{
    static void Main(string[] args)
    {
        // create a base "Assignment" Object
        Assignment a1 = new Assignment("Johnson Akpama","Multiplication");
        Console.WriteLine .GetSummary(a1 _GetSummary());
    
       // Now create the derived class assignments

       Assignment a2 = new Assignment("Ruben John","Addition" "21+4","15+10");
       Console.WriteLine(a2.GetSummary());
       Console.writeLine(a2.GetHomeworkList());

       WritingAssignment a3 = new WritingAssignment("Sarah Ehi","European History","The cause of the world war11");
       Console.WriteLine(a3.GetSummary());
       Console.WriteLine(a3.GetWritingInformation());

    }
}