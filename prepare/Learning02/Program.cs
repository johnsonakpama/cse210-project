using System;

class Program
{
    static void Main(string[] args)
    {
       job job1 = new job();
        job1._jobTitle = "Software Engineer";
        job1._jobTitle = "Software Engineer";
        job1._compamy = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        job job2 = new job();
        job2._jobTitle = "Manager";
        job2._compamy = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Allison Rose";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display(); = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        job Job2 = new job();
        job2._jobTitle = "Manager";
        job2._compamy = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();
        myResume._name = "Johnson Akpama";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display(); 
    }
    
}