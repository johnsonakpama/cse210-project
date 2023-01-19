using System;
public class Resume
{
    public string _name;

    //make sure Initialize your list to a new list before you use it
    public List<job> _jobs = new List<job>();
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Job: {_jobs}");
        // Notice the use of the custom Date type "job" in the loop
        foreach(job job in _jobs)
        {
            // The call the Display method on each job
            job.Display();
        }
    }

}