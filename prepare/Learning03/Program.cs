using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction fraction = new Fraction();
        Fraction fraction1 = new Fraction(3);
        Fraction fraction2 = new Fraction(3,5);

        Console.WriteLine(fraction.getTop());
        Console.WriteLine(fraction.getBottom());

        fraction.setTop(4);
        fraction.setBottom(6);

        Console.WriteLine(fraction.getTop());
        Console.WriteLine(fraction.getBottom());

        Console.WriteLine($"{fraction.GetFractionString()}, {fraction.GetDecimalValue()}");


        Random rand= new Random();
        Fraction fraction3 = new Fraction();

        for (int i = 0; i < 30; i++)
        {
            int topValue = rand.Next(1, 11);
            int bottomValue = rand.Next(1, 11);
            fraction3.setTop(topValue);
            fraction3.setBottom(bottomValue);
            Console.WriteLine($"Fraction {i + 1}: string: {fraction3.GetFractionString()} Number: {fraction3.GetDecimalValue()}");
        }
    }
}