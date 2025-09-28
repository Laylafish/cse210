using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        // job1
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "apple";
        job1._startYear = 2001;
        job1._endYear = 2020;

        // job2
        Job job2 = new Job();
        job2._jobTitle = "Baker";
        job2._company = "CornerBakery";
        job2._startYear = 1990;
        job2._endYear = 2000;

        // resume1
        Resume myResume = new Resume();
        myResume._name = "Mariane Lee";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}