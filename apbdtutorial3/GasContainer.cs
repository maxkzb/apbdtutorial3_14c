namespace apbdtutorial3;

public class GasContainer : Container, IHazardNotifier
{
    public double Pressure { get; }
    public GasContainer(double tareWeight, double maxPayload, double pressure) 
        : base("G", tareWeight, maxPayload)
    {
        Pressure = pressure;
    }

    public override void EmptyCargo()
    {
        CargoMass *= 0.05;
    }

    public void NotifyHazard(string message)
    {
        Console.WriteLine($"{message} In container: {SerialNumber}");
    }
}