using SingleResponsibility.Models;

namespace SingleResponsibility.Services;

public class LaptopPrinter
{
    private Laptop _laptop;

    public LaptopPrinter(Laptop laptop)
    {
        _laptop = laptop;
    }
    
    public void Print()
    {
        Console.WriteLine($"Laptop[ Model = {_laptop.Model}, " +
                          $"Processor = {_laptop.Processor}, " +
                          $"OperatingSystem = {_laptop.OperatingSystem}, " +
                          $"BatteryStatus = {_laptop.Battery}%]");
    }
}