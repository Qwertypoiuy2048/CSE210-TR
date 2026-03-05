public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string name, string color, double length, double width) : base(name, color)
    {
        _length = length;
        _width = width;
    }

    public override double GetArea()
    {
        return _length * _width;
    }
}
