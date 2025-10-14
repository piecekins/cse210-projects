

using System.Security.Cryptography.X509Certificates;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void GetTop()
    {
        Console.WriteLine(_top);
    }
    public void SetTop(int top)
    {
        _top = top;
    }

    public void GetBottom()
    {
        Console.WriteLine(_bottom);
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string value = $"{_top}/{_bottom}";
        return value;
    }
    
    public double GetDecimalValue()
    {
        double bottom = _bottom; 
        double value = _top / bottom;
        return value;
    }

}