using SingleResponsibility.Models;

namespace SingleResponsibility.Services;

public class LaptopCharger
{
    private Laptop _laptop;
    public LaptopCharger(Laptop laptop)
    {
        _laptop = laptop;
    }

    public void Charge()
    {
        if (_laptop.Battery + 5 > 100)
            _laptop.Battery = 100;
        _laptop.Battery += 5;
        
        Console.WriteLine("Charging");
    }

    public bool IsFullCharged()
    {
        if (_laptop.Battery == 100) {
            Console.WriteLine("Laptop fully charged");
            return true;
        }
        return false;
    }
}