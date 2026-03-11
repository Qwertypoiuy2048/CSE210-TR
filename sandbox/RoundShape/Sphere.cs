using System.Buffers.Text;

class Sphere : Circle
{
    public Sphere(double r) : base(r)
    {
        
    }

    public override double GetArea()
    {
        return 4 * base.GetArea();
    }
}
