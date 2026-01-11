using System;
/*
Write a program that determines the letter grade for a course according to the following scale:
A >= 90
B >= 80
C >= 70
D >= 60
F < 60
*/
class Program
{
    static void Main(string[] args)
    {
        string gradeNumberStr;
        int gradeNumber;
        string gradeLetter;
        bool pass;
        Console.Write("\nWhat is your grade? ");
        gradeNumberStr = Console.ReadLine();
        gradeNumber = int.Parse(gradeNumberStr);
        if (gradeNumber >= 80)
        {
            if (gradeNumber >= 90)
            {
                pass = true;
                gradeLetter = " A!";
            } else
            {
                pass = true;
                gradeLetter = " B!";
            }
        } else
        {
            if (gradeNumber >= 70)
            {
                pass = true;
                gradeLetter = " C";
            } 
            else if (gradeNumber >= 60)
            {
                pass = false;
                gradeLetter = " D";
            } 
            else
            {
                pass = false;
                gradeLetter = " F :(";
            }
        }

        Console.WriteLine($"You have a{gradeLetter}");
        if (pass)
        {
            Console.WriteLine($"You Passed the class!\n");
        } else
        {
            Console.WriteLine($"Not passing yet. You got this!\n");
        }
        
        
    }
}