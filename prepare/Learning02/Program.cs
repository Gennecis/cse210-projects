using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2027;
        job1._endYear = 2032;
        job1.Display();
        // Console.WriteLine($"first job: {job1.DisplayJob()}");
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2032;
        job2._endYear = 2040;
        job2.Display();
        // Console.WriteLine($"second job: {job2.Display()}");

        Resume myResume = new Resume();
        myResume._name = "Pascal";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.Display();
    }
}