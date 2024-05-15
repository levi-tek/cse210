using System;

public class fraction
{
    private int _top;
    private int _bottom;

    public fraction ()
    {
        _top = 1;
        _bottom = 1;
    }
    public fraction(int number)
    {
        _top = number;
        _bottom = 1;
    }

    public fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }
     public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}