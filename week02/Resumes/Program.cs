using System;
using System.Security.Cryptography.X509Certificates;

namespace Resumesprojet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is the Resumes Project.");

            Job job1 = new Job();
            job1._jobTitle = "Software Engineer";
            job1._company = "Miscrosoft";
            job1._startYear = 2020;
            job1._endYear = 2023;

            Job job2 = new Job();
            job2._jobTitle = "Software Developer";
            job2._company = "Apple";
            job2._startYear = 2018;
            job2._endYear = 2020;

            Resume myResume = new Resume();
            myResume._name = "John Doe";
            myResume._jobs.Add(job1);
            myResume._jobs.Add(job2);

            myResume.Display();

            

        }
    }
}

