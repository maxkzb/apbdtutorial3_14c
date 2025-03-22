﻿using apbdtutorial3;

class Program
{
    static void Main()
    {
        ContainerShip ship1 = new ContainerShip("Poseidon", 30, 5, 5);
        ContainerShip ship2 = new ContainerShip("Neptune", 25, 5, 6);
        
        RefrigeratedContainer bananaContainer = new RefrigeratedContainer(300, 1000, 250, 200, "Bananas", 5);
        LiquidContainer milkContainer = new LiquidContainer(250, 1200, false);
        GasContainer heliumContainer = new GasContainer(200, 800, 50);
        LiquidContainer fuelContainer = new LiquidContainer(270, 1100, true);
        
        try
        {
            bananaContainer.LoadCargo(900);
            milkContainer.LoadCargo(1000);
            heliumContainer.LoadCargo(700);
            fuelContainer.LoadCargo(500); // Should throw exception if exceeding 50% capacity
        }
        catch (OverfillException ex)
        {
            Console.WriteLine(ex.Message);
        }
        
        bananaContainer.PrintCargo();
        milkContainer.PrintCargo();
        heliumContainer.PrintCargo();
        fuelContainer.PrintCargo();
        
        ship1.LoadContainer(bananaContainer);
        ship1.LoadContainer(milkContainer);
        ship1.LoadContainer(heliumContainer);
        ship1.LoadContainer(fuelContainer);
        
        ship1.PrintShipInfo();
        
        ship1.RemoveContainer(milkContainer);
        Console.WriteLine("Milk container removed.");
        ship1.PrintShipInfo();
        
        RefrigeratedContainer fishContainer = new RefrigeratedContainer(280, 900, 260, 220, "Fish", -2);
        ship1.ReplaceContainer(bananaContainer.SerialNumber, fishContainer);
        Console.WriteLine("Banana container replaced with fish container.");
        ship1.PrintShipInfo();
        
        ContainerShip.TransferContainer(ship1, ship2, heliumContainer.SerialNumber);
        Console.WriteLine("Helium container transferred to another ship.");
        ship1.PrintShipInfo();
        ship2.PrintShipInfo();
    }
}