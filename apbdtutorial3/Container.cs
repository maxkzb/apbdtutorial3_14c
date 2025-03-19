namespace apbdtutorial3;

public class Container
{
    private static int _counter = 0;
    public string SerialNumber { get; }
    public double MaxPayload { get; protected set; }
    public double TareWeight { get; protected set; }
    public double CargoMass { get; private set; }
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
}