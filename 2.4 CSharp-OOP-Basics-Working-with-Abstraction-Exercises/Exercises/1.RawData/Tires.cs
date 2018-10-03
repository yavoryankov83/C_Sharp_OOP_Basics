public class Tires
{
    public double TirePressure { get; private set; }
    public int TireAge { get; private set; }

    public Tires(double tirePressure, int tireAge)
    {
        TirePressure = tirePressure;
        TireAge = tireAge;
    }
}