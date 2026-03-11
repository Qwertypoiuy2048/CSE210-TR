class Cylinder : Circle
{
    public int _height;
    public Cylinder(double radius, int height) : base(radius)
    {
        _height = height;
    }
    public override double GetArea()
    {
        return 2 *Math.PI * _radius *(_radius + _height);
    }
}