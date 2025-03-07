using System;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        string lettergrade = "";
        string finalgrade = "";
        string grade = "";

        Console.Write("Please enter your final score (out of 100): ");
        string input = Console.ReadLine();

        int number = int.Parse(input);

        if (number >= 90)
        {
            lettergrade = "A";
        }

        else if  (number >= 80 && number < 90)
        {
            lettergrade = "B";
        }

        else if  (number >= 70 && number < 80)
        {
            lettergrade = "C";
        }

        else if  (number >= 60 && number < 70)
        {
            lettergrade = "D";
        }

        else
        {
            lettergrade = "F";
        }

        int lastnumber = number % 10;

        if (lettergrade != "F")
        {
            if (lettergrade != "A")
            {
                if (lastnumber >= 7 && lastnumber <= 9)
                {
                    grade = "+";
                }
            }

            else if (lastnumber >= 0 && lastnumber <= 3)
            {
                grade = "-";
            }

            else
            {
                grade = "";
            }
        }
        
        finalgrade = lettergrade + grade;

        Console.WriteLine($"Your Final grade is // {finalgrade} //");

        if (number >= 70)
        {
            Console.WriteLine("Congrats, you have passed.");
        }

        else
        {
            Console.WriteLine("Sorry, you have failed.\nPlease try again!");
        }

    }
}