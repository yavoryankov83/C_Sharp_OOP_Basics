public class Engine
{
    public string Model { get; private set; }
    public int Power { get; private set; }
    public int? Displacement { get; set; }
    public string Efficiency { get; set; }

    public Engine(string model, int power)
    {
        Model = model;
        Power = power;
    }
}