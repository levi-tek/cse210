using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        job job1 = new job();
        job1._jobTitle = "Full Time Missionary";
        job1._company = "The Church of Jesus Christ of Latter Day-Saint";
        job1._startYear = 2020;
        job1._endYear = 2022;
        // job1.DisplayDetails();


        job job2 = new job();
        job2._jobTitle = "Field Agent ";
        job2._company = "Family Search";
        job2._startYear = 2023;
        job2._endYear = 2024;
        // job2.DisplayDetails();

        resume resume = new resume();
        resume._name = "Levi Oguike";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();
        


    }
}