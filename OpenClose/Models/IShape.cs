using System.Reflection;

namespace OpenClose.Models;

public interface IShape
{
    public double CountArea();
    public double CountPerimeter();
    public string GetParameter();
}