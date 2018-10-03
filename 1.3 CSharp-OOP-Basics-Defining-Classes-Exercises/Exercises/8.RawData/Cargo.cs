public class Cargo
{
    private int cargoWeight;
    private string cargoType;

    public Cargo(int cargoWeight, string cargoType)
    {
        this.cargoWeight = cargoWeight;
        this.CargoType = cargoType;
    }

    public string CargoType
    {
        get { return cargoType; }
        set { cargoType = value; }
    }


    public int CargoWeight
    {
        get { return cargoWeight; }
        set { cargoWeight = value; }
    }

}