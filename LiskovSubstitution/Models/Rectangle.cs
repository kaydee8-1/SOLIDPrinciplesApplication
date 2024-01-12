namespace LiskovSubstitution.Models;

public class Rectangle
{
    public double Width { get; set; }
    public double Length { get; set; }

    public Rectangle(double width, double length)
    {
        Width = width;
        Length = length;
    }

    public double GetWidth()
    {
        return Width;
    }
    
    public double GetLength()
    {
        return Length;
    }
    
    public virtual void SetWidth(double width)
    {
        Width = width;
    }
    
    public virtual void SetLength(double length)
    {
        Length = length;
    }

    public virtual double CalculateArea()
    {
        return Width * Length;
    }

}