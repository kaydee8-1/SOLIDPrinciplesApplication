using OpenClose.Models;

namespace OpenClose.Services;

public class ShapePrinter
{
    public void PrintArea(IShape shape)
    {
        Console.WriteLine(
            $"{shape.CountArea()}");
    }
    
    public void PrintPerimeter(IShape shape)
    {
        Console.WriteLine(
            $"{shape.CountPerimeter()}");
    }
    
}