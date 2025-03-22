namespace apbdtutorial3;

public class LiquidContainer : Container, IHazardNotifier
{
    public bool IsHazardous { get; set; }

    public LiquidContainer(double tareWeight, double maxPayload, bool isHazardous)
        : base("L", tareWeight, maxPayload)
    {
        isHazardous = isHazardous;
    }
    public override void LoadCargo(double mass)
    {
        double limit = IsHazardous ? MaxPayload * 0.5 : MaxPayload * 0.9;
        if (CargoMass + mass > limit)
        {
            NotifyHazard($"Attempted to overload a hazardous liquid container.");
            throw new OverfillException($"Cannot load {mass} kg. Exceeds max allowed capacity of {limit} kg.");
        }
        CargoMass += mass;
    }
    public void NotifyHazard(string message)
    {
        Console.WriteLine($"{message} In container: {SerialNumber}");
    }

    public override void PrintCargo()
    {
        Console.WriteLine($"Hazardous: {IsHazardous}");
    }
}