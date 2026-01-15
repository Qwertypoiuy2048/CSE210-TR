using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int num = 1;
        List<int> allNums = [];
        int sum = 0;
        float avg = 0;
        int max = 0;

        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("\nEnter a list of numbers, type 0 when finished.\n");
        
        while (num != 0)
        {
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            allNums.Add(num);
        } 

        foreach(int i in allNums){
            sum += i;
            if (i > max)
            {
                max = i;
            }
        }
        Console.WriteLine($"The sum is: {sum}");

        avg = sum / allNums.Count;
        Console.Write(allNums.Count);
        Console.WriteLine($"The average is: {avg}");
        
        Console.WriteLine($"The largest number is: {max}");


    }
}
