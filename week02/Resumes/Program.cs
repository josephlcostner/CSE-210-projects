using System;
using System.IO.Pipes;
using System.Reflection.Metadata;
using System.Security.AccessControl;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

    
   Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = "2019";
        job1._endYear = "2022";
        job1.Display;
    Job job2 = new Job();
        job2._jobTitle = "Programmer";
        job2._company = "Apple";
        job2._startYear = "2022";
        job2._endYear = "2023";
        Console.WriteLine(job1.Display());
        Console.WriteLine($"{job2._company}");
    }
    
    
}