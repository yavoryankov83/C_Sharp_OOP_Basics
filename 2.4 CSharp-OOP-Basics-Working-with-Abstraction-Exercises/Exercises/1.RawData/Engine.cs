public class Engine
{
    public double EngineSpeed { get; private set; }
    public double EnginePower { get; private set; }

    public Engine(double engineSpeed, double enginePower)
    {
        EngineSpeed = engineSpeed;
        EnginePower = enginePower;
    }

}