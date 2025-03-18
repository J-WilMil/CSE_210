using System;

public class Numbers
{
    private int _top;
    private int _bottom;

    public Numbers()
    {
        _top = 1;
        _bottom = 1;
    }    

    public Numbers(int top)
    {
        _top = top;
        _bottom = 1;
    }

    public Numbers(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
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