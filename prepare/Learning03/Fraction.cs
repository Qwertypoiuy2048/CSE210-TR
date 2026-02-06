using System;

public class Fraction
{
    private int _top;
    private int _bottom;


    // Constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int number)
    {
        _top = number;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }


    // Get and set
    public int getTop() 
    { 
        return _top; 
    }
    public void setTop(int value) 
    { 
        _top = value; 
    }

    public int getBottom() 
    { 
        return _bottom; 
    }
    public void setBottom(int value)
    {
        _bottom = value;
    }
    

    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}
