namespace InterfaceSegregation.Model;

public class Car : IVehicle, IMovable
{
    private string _registration;
    private string _color;

    public Car(string registration, string color)
    {
        _registration = registration;
        _color = color;
    }
    
    public void SetColor()
    {
        throw new NotImplementedException();
    }

    public void SetRegistration()
    {
        throw new NotImplementedException();
    }

    public void EngineOn()
    {
        throw new NotImplementedException();
    }

    public void EngineOff()
    {
        throw new NotImplementedException();
    }
}