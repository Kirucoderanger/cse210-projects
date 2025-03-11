using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");
       
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Programer";
        job1._startYear = 2020;
        job1._endYear = 2021;
        //job1.Display();
        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2021;
        job2._endYear = 2022;
        //job2.Display();
       

        Resume myResume = new Resume();
        myResume.name = "kirubel Mekonen";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume.DisplayAll();
        

    }
}