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
        if (Containers.Count >= MaxNumOfContainers || GetTotalWeight() + (container.TareWeight + container.CargoMass) / 1000 > MaxWeight)
        {
            Console.WriteLine("Cannot load container. Ship capacity exceeded.");
            return false;
        }
        Containers.Add(container);
        return true;
    }
    public void LoadContainersFromList(List<Container> containers)
    {
        foreach (var container in containers)
        {
            LoadContainer(container);
        }
    }
    public void RemoveContainer(Container container)
    {
        Containers.Remove(container);
    }
    public void ReplaceContainer(string serialNumber, Container newContainer)
    {
        for (int i = 0; i < Containers.Count; i++)
        {
            if (Containers[i].SerialNumber == serialNumber)
            {
                Containers[i] = newContainer;
                return;
            }
        }
    }
    public static void TransferContainer(ContainerShip fromShip, ContainerShip toShip, string serialNumber)
    {
        Container container = fromShip.Containers.Find(c => c.SerialNumber == serialNumber);
        if (container != null)
        {
            if (toShip.LoadContainer(container))
            {
                fromShip.RemoveContainer(container);
            }
        }
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
        Console.WriteLine($"Ship: {Name}, Speed: {MaxSpeed} knots, Containers: {Containers.Count}/{MaxNumOfContainers}, Weight: {GetTotalWeight() / 1000}/{MaxWeight / 1000} tons");
    }
}