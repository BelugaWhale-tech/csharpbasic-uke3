public class Beacon
{
    public int Frequency { get; set; }
    public static int CreatedCount { get; private set; }

    public Beacon(int frequency)
    {
        Frequency = frequency;
        // TODO: Oppdater CreatedCount.
    }
}
