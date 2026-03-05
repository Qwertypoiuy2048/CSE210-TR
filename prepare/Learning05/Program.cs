using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Square1", "Green", 5));
        shapes.Add(new Rectangle("Rectangle1", "Blue", 4, 6));
        shapes.Add(new Circle("Circle1", "Red", 2.5));
        
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()}: {shape.GetArea():F2}");
        }
    }
}
