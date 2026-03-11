class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Circle circle = new Circle(2);
        Console.WriteLine($"The area of the circle is {circle.GetArea()}");
        Cylinder cylinder = new Cylinder(10, 2);
        Console.WriteLine($"The surface area of the cylinder is {cylinder.GetArea()}");
        Sphere sphere = new Sphere(500);
        Console.WriteLine($"The volume of the sphere is {sphere.GetArea()}");
    }
}
