using OpenClose.Models;
using OpenClose.Services;

namespace OpenClose;

class Program
{
    static void Main(string[] args)
    {
        List<IShape> shapes = new List<IShape>();
        shapes.Add(new Circle(1));
        shapes.Add(new Square(3));
        shapes.Add(new Square(40));

        ShapePrinter shapePrinter = new ShapePrinter();
        
        shapes.ForEach(shape =>
        {
            Console.WriteLine($"{shape.GetType().Name} area with {shape.GetParameter()} = ");
            shapePrinter.PrintArea(shape);
            
            Console.WriteLine($"{shape.GetType().Name} perimeter with {shape.GetParameter()} = ");;
            shapePrinter.PrintPerimeter(shape);
        });
    }
}