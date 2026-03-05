public class Shape
{
    private string _name;
    private string _color;

    public Shape(string name, string color)
    {
        _name = name;
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 0;
    }
}