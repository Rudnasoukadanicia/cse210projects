using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment Assigment1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(Assigment1.GetSummary());

        MathAssignment mathAssignment1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());

    }
}