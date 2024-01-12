using System.Text.Json.Serialization.Metadata;

namespace LiskovSubstitution.Models;

public class Square : Rectangle
{
    public Square(double side) : base(side, side) {}

    public override void SetLength(double length)
    {
        base.SetLength(length);
        base.SetWidth(length);
    }

    public override void SetWidth(double width)
    {
        base.SetWidth(width);
        base.SetLength(width);
    }
}