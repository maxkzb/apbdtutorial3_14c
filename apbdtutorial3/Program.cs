using apbdtutorial3;

class Program
{
    static void Main()
    {
        RefrigeratedContainer bananaContainer = new RefrigeratedContainer(500, 2000, 250, 300, "Bananas", 5);
        LiquidContainer milkContainer = new LiquidContainer(400, 1500, false);
        GasContainer heliumContainer = new GasContainer(600, 1200, 30);
        
        bananaContainer.LoadCargo(1800);
        milkContainer.LoadCargo(1300);
        heliumContainer.LoadCargo(1000);
        
        ContainerShip ship = new ContainerShip("Poseidon", 30, 3, 5000);
        
        ship.LoadContainer(bananaContainer);
        ship.LoadContainer(milkContainer);
        ship.LoadContainer(heliumContainer);
        
        ship.PrintShipInfo();
        
        bananaContainer.PrintCargo();
        milkContainer.PrintCargo();
        heliumContainer.PrintCargo();
    }
}