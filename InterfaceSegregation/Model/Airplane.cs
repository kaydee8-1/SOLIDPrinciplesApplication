using System.Runtime.InteropServices.JavaScript;

namespace InterfaceSegregation.Model;

public class Airplane : IVehicle, IFlyable
{
    private string _productionNo;
    private string _color;

    public Airplane(string productionNo, string color)
    {
        _productionNo = productionNo;
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

    public void TakeOff()
    {
        throw new NotImplementedException();
    }

    public void Landing()
    {
        throw new NotImplementedException();
    }
}