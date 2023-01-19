using System;

public class job
{
   public string _jobTitle;
   public string _compamy;
   public int _startYear;
   public int _endYear;
   public void Display()
   {
    Console.WriteLine($"{_jobTitle} ({_compamy}) {_startYear}-{_endYear}");
   }

}
