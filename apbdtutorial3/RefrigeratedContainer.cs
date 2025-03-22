namespace apbdtutorial3;

public class RefrigeratedContainer : Container, IHazardNotifier
{
    public RefrigeratedContainer(double tareWeight, double maxPayload, double height, double depth, string productType, double temperature) 
        : base("C", tareWeight, maxPayload, height, depth)
    {
        ProductType = productType;
        Temperature = temperature;
    }

    public void NotifyHazard(string message)
    {
        Console.WriteLine($"{message} In container: {SerialNumber}");
    }

    public override void PrintCargo()
    {
        Console.WriteLine($"Product Type: {ProductType}, Temperature: {Temperature}°C");
    }
}