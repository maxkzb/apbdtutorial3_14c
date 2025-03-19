namespace apbdtutorial3;

public class Container
{
    private static int _counter = 0;
    public string SerialNumber { get; }
    public double MaxPayload { get; protected set; }
    public double TareWeight { get; protected set; }
    public double CargoMass { get; protected set; }
    public double Height { get; set; }
    public double Depth { get; set; }
    public string ProductType { get; protected set; }
    public double Temperature { get; protected set; }
    
    protected Container(string type, double tareWeight, double maxPayload, double height = 0, double depth = 0)
    {
        SerialNumber = $"KON-{type}-{_counter++}";
        TareWeight = tareWeight;
        MaxPayload = maxPayload;
        Height = height;
        Depth = depth;
        CargoMass = 0;
    }
    public virtual void LoadCargo(double mass)
    {
        if (CargoMass + mass > MaxPayload)
        {
            throw new OverfillException("Too much mass for overfill");
        }
        CargoMass += mass;
    }

    public virtual void EmptyCargo()
    {
        CargoMass = 0;
    }
}