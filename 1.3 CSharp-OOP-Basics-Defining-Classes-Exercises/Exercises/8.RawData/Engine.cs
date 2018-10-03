public class Engine
{
    private int engineSpeed;
    private int enginePower;

    public Engine(int engineSpeed, int enginePower)
    {
        this.EnginePower = enginePower;
        this.EngineSpeed = engineSpeed;
    }

    public int EnginePower
    {
        get { return enginePower; }
        set { enginePower = value; }
    }


    public int EngineSpeed
    {
        get { return engineSpeed; }
        set { engineSpeed = value; }
    }

}