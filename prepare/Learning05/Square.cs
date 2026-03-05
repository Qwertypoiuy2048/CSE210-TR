public class Square : Shape
{
    private double _side;

    public Square(string name, string color, double sideLength) : base(name, color)
    {
        _side = sideLength;
    }

    public override double GetArea()
    {
        return _side * _side;
    }
}
