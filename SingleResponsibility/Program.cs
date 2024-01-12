using SingleResponsibility.Models;
using SingleResponsibility.Services;

namespace SingleResponsibility;

class Program
{
    static void Main(string[] args)
    {
        List<Laptop> laptops = new List<Laptop>();
        laptops.AddRange(new List<Laptop>() {
            new Laptop("DELL 1234", "Intel i7", "Windows"),
            new Laptop("ASUS 434534",  "Ryzen 7", "Linux"),
            new Laptop("Mac Pro", "M1", "IOS")
        }) ;

        LaptopBatteryUsage firstLaptopBatteryUsage = new LaptopBatteryUsage(laptops[0]);
        LaptopCharger firstLaptopCharger = new LaptopCharger(laptops[1]);
        
        while (firstLaptopBatteryUsage.canUse())
        {
            firstLaptopBatteryUsage.Use();
        }

        while (!firstLaptopCharger.IsFullCharged())
        {
            firstLaptopCharger.Charge();
        }
        
        
    }
}