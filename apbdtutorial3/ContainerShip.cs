namespace apbdtutorial3;

public class ContainerShip
{
    public List<Container> Containers { get;}
    public double MaxSpeed { get; }
    public double MaxNumOfContainers { get; }
    public double MaxWeight { get; }
    public string Name { get; }

    public ContainerShip(string name, double maxSpeed, double maxNumOfContainers, double maxWeight)
    {
        Containers = new List<Container>();
        Name = name;
        MaxSpeed = maxSpeed;
        MaxNumOfContainers = maxNumOfContainers;
        MaxWeight = maxWeight;
    }
    public bool LoadContainer(Container container)
    {
        if (Containers.Count >= MaxNumOfContainers || GetTotalWeight() + container.TareWeight + container.CargoMass > MaxWeight * 1000)
        {
            Console.WriteLine("Cannot load container. Ship capacity exceeded.");
            return false;
        }
        Containers.Add(container);
        return true;
    }
    public void RemoveContainer(Container container)
    {
        Containers.Remove(container);
    }

    public double GetTotalWeight()
    {
        double totalWeight = 0;
        foreach (var container in Containers)
        {
            totalWeight += container.TareWeight + container.CargoMass;
        }
        return totalWeight;
    }

    public void PrintShipInfo()
    {
        Console.WriteLine($"Ship: {Name}, Speed: {MaxSpeed} knots, Containers: {Containers.Count}/{MaxNumOfContainers}, Total Weight: {GetTotalWeight() / 1000} tons");
    }
}