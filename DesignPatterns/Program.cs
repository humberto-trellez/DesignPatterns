// Polymorphism

// Poly = many

// Morph = forms

// Polymorphism is ability of an object to take many forms

using DesignPatterns.OOPPrinciples.Polymorphism;

List<Vehicle> vehicles = new List<Vehicle>();
vehicles.Add(new Car { Brand = "Fiat", Model = "Pulse", Year=2026, NumberOfDoors = 4 });
vehicles.Add(new Motorcycle { Brand = "Indian", Model = "Scout", Year = 2026 });

// Vehicle inspection
foreach (var vehicle in vehicles)
{
    vehicle.Start();
    vehicle.Stop();
}