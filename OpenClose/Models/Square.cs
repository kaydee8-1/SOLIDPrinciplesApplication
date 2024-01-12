namespace OpenClose.Models;

public class Square : IShape
{
    public double _side { get; set; }

    public Square(int side)
    {
        _side = side;
    }
    
    public double CountArea()
    {
        return _side * _side;
    }

    public double CountPerimeter()
    {
        return 4 * _side;
    }

    public string GetParameter()
    {
        return $"Side({_side})";
    }
}