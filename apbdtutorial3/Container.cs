namespace apbdtutorial3;

public class Container
{
    private static int _counter = 0;
    public string SerialNumber { get; }
    public double MaxPayload { get; protected set; }
    public double TareWeight { get; protected set; }
    
    protected Container(string type)
    {
        SerialNumber = $"KON-{type}-{_counter++}";
    }
}