// See https://aka.ms/new-console-template for more information


using InterfaceSegregation.Model;

Car car = new Car("EF67ZMR", "Red");
car.SetColor();
car.EngineOff();
car.EngineOn();
car.SetRegistration();

Airplane airplane = new Airplane("ABC123", "White");
airplane.TakeOff();
airplane.Landing();
airplane.SetRegistration();
airplane.SetColor();