using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";

        //Console.WriteLine(job1._jobTitle);

        Job job2 = new Job();


        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        job2._company = "Apple";
        job2._startYear = 2023;
        job2._endYear = 2023;
        job2._jobTitle = "Manager";

        //Console.WriteLine(job1._company);
        //Console.WriteLine(job2._company);
        //job1.DisplayJob();
        //job2.DisplayJob();

        Resume myResume = new Resume();

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._name = "Allison Rose";

        //Console.WriteLine(myResume._jobs[0]._jobTitle);
        myResume.DisplayResume();
    }


}