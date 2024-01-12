using System.Reflection.Metadata;

namespace SingleResponsibility.Models;

public class Laptop
{
    public string Model { get; set; }
    public string Processor { get; set; }
    public string OperatingSystem { get; set; }
    public int Battery { get; set; }

    public Laptop(string model, string processor, string operatingSystem)
    {
        Model = model;
        Processor = processor;
        OperatingSystem = operatingSystem;
        Battery = 100;
    }
}