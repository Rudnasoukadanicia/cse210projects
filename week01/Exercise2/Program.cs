using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("what is the grade percent ? ");
        string valueFromUser = Console.ReadLine();
        int percent = int.Parse(valueFromUser);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";

        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        int lastDigit = percent % 10;
        string sign = "";

        if (lastDigit >= 7)
        {
            sign = "+";
            Console.WriteLine(sign);
        }
        else if (lastDigit < 3)
        {
            sign = "-";
            Console.WriteLine(sign);
        }
        else
        {
            sign = "";
            Console.WriteLine(sign);
        }

        if (letter == "A" && sign == "+")
        {
            sign = "";
            Console.WriteLine(sign);
        }
        else if (letter == "F")
        {
            sign = "";
            Console.WriteLine(sign);
        }

        Console.WriteLine($"You have earned the grade {letter}{sign}");

        if (percent >= 80)
        {
            Console.WriteLine("Congratulations !");
        }
        else
        {
            Console.WriteLine("Sorry your grade is fail");
        }


    }
}