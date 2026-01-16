using System;
using System.Globalization;

/*
DisplayWelcome - Displays the message, "Welcome to the Program!"
PromptUserName - Asks for and returns the user's name (as a string)
PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
PromtUserBirthYear - Accepts out integer parameter and prompts the user for the year they were born. The out parameter is set to their birth year. This function does not return a value. The user's birth year is given back from the function via the out parameter.
SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
DisplayResult - Accepts the user's name, the squared number, and the user's birth year. Display the user's name and squared number. Calculate hold many years old they will turn this year and display that.

*/
class Program
{
    static void DisplayWelcome()//Displays the message, "Welcome to the Program!"
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()//Asks for and returns the user's name (as a string)
    {
        Console.WriteLine("What is your name? ");

        string name = Console.ReadLine();

        return name;
    }
    static int PromptUserNumber()//Asks for and returns the user's favorite number (as an integer)
    {
        Console.WriteLine("What is your favorite number? ");

        int num = int.Parse(Console.ReadLine());

        return num;
    }
    static void PromtUserBirthYear(out int year)//Accepts out integer parameter and prompts the user for the year they were born. The out parameter is set to their birth year. This function does not return a value. The user's birth year is given back from the function via the out parameter.
    {
        Console.WriteLine("What year were you born? ");

        year = int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int num)//Accepts an integer as a parameter and returns that number squared (as an integer)
    {
        int square = num*num;

        return square;
    }
    static void DisplayResult(string name, int square, int year)//Accepts the user's name, the squared number, and the user's birth year. 
    // Display the user's name and squared number. Calculate hold many years old they will turn this year and display that.
    {
        Console.WriteLine($"{name}, the square of your number is {square}");

        int age = 2026-year;
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        int year;
        DisplayWelcome();
        string name = PromptUserName();
        int num = PromptUserNumber();
        PromtUserBirthYear(out year);
        int square = SquareNumber(num);

        DisplayResult(name, square, year);
    }
}