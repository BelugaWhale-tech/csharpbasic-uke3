Drone alpha = new Drone("Alpha", 40);
Drone beta = new Drone("Beta", 115);
Drone gamma = new Drone("Gamma", 100);

Drone[] drones = { alpha, beta, gamma };

foreach (Drone drone in drones)
{
    Console.WriteLine(drone.Describe());
    Console.WriteLine($"Needs service: {drone.NeedsService()}");
}
