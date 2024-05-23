using System;

class Program
{
    static void Main(string[] args)
    {// create two new instances of job
        Job job1 = new Job("Software Engineer", "Microsoft", 2019, 2022);
        Job job2 = new Job("Manager", "Apple", 2022, 2023);

        job1.Display();
        job2.Display();

        // create new instance of resume
        Resume myResume = new Resume("John Doe");
        myResume.AddJob(job1);
        myResume.AddJob(job2);

        myResume.Display();
    }
}