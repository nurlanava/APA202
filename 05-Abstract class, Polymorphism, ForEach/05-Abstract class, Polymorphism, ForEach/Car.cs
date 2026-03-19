class Car : Vehicle
{
    public int DoorsCount;
    public int TrunkCapacity;
    public bool IsAutomatic;
    public int MaxSpeed;

    public Car(string brand, string model, int year, string plateNumber,
        int doors, int trunk, bool isAuto, int maxSpeed)
        : base(brand, model, year, plateNumber)
    {
        this.DoorsCount = doors;
        this.TrunkCapacity = trunk;
        this.IsAutomatic = isAuto;
        this.MaxSpeed = maxSpeed;
    }

    public void ShowCarInfo()
    {
        ShowBasicInfo();
        Console.WriteLine($"Doors:{DoorsCount}, Trunk:{TrunkCapacity}, Automatic:{IsAutomatic}, MaxSpeed:{MaxSpeed}");
    }

    public double CalculateFuelCost(double distance)
    {
        return (distance / 100) * 8 * 1.50;
    }
}
