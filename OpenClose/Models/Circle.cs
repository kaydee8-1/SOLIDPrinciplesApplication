namespace OpenClose.Models;

public class Circle : IShape
{
    public double _radius { get; set; }
    private static double PI = Double.Pi;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double CountArea()
    {
        return PI * _radius * _radius;
    }

    public double CountPerimeter()
    {
        return 2 * PI * _radius;
    }

    public string GetParameter()
    {
        return $"Radius({_radius})";
    }
}