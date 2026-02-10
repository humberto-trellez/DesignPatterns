namespace DesignPatterns.SOLID.D;

public class Car
{
    private IEngine _engine;

    public Car(IEngine engine)
    {
        this._engine = engine;
    }

    public void StartCar()
    {
        _engine.Start();
        Console.WriteLine("Car started");
    }
}