using SingleResponsibility.Models;

namespace SingleResponsibility.Services;

public class LaptopBatteryUsage
{
    private Laptop _laptop;
    
    public LaptopBatteryUsage(Laptop laptop)
    {
        _laptop = laptop;
    }
    
    public void Use()
    {
        if (_laptop.Battery - 5 < 0)
        {
            Console.WriteLine($"Laptop is about to die, {_laptop.Battery}% left");
            _laptop.Battery = 0;
            return;
        }
        Console.WriteLine("Using");
        _laptop.Battery -= 5;
    }

    public bool canUse()
    {
        if (_laptop.Battery == 0)
        {
            Console.WriteLine("Can't use laptop, battery is dead");
            return false;
        }

        return true;
    }
}