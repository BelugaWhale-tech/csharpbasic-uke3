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
