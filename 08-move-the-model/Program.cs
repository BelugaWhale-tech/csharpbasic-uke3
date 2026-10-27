Probe probe = new Probe("Pioneer", 88);
Console.WriteLine(probe.Describe());

// TODO: Flytt denne klassen til Probe.cs.
public class Probe
{
    public string Name { get; set; }
    public int SignalStrength { get; set; }

    public Probe(string name, int signalStrength)
    {
        Name = name;
        SignalStrength = signalStrength;
    }

    public string Describe()
    {
        return $"{Name}: signal {SignalStrength}";
    }
}
