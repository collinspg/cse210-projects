using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Kolie's Electric";
        job1._jobTitle = "Electrical Engineer";
        job1._startYear = 2015;
        job1._endYear = 2019;

        Job job2 = new Job();
        job2._company = "Bloom-Byu-Pathway Worldwide";
        job2._jobTitle = "Mentor";
        job2._startYear = 2022;
        job2._endYear = 2024;

        Resume personalResume = new Resume();
        personalResume._name = "Collins Okolie";

        personalResume._jobs.Add(job1);
        personalResume._jobs.Add(job2);

        personalResume.DisplayResume();
    }
}