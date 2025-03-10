using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Resumes Project.");

        Job job1 = new Job();
        job1._company = "Blizzard";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2005;
        job1._endYear = 2025;

        job1.Display();

        Job job2 = new Job();
        job2._company = "Pokemon";
        job2._jobTitle = "Project Manager";
        job2._startYear = 2017;
        job2._endYear = 2025;

        job2.Display();

        Resume myResume = new Resume();
        myResume._name = "Harry";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        Console.WriteLine(myResume._jobs[0]._jobTitle);

        myResume.Display();
    }
}