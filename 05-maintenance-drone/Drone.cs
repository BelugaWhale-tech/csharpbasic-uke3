public class Drone
{
    public string Name { get; set; }
    public int FlightHours { get; set; }

    public Drone(string name, int flightHours)
    {
        Name = name;
        FlightHours = flightHours;
    }

    public string Describe()
    {
        // TODO
        return "";
    }

    public bool NeedsService()
    {
        // TODO
        return false;
    }
}
