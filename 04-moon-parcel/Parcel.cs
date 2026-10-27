public class Parcel
{
    public string TrackingCode { get; set; } = "";
    public string Destination { get; set; } = "";
    public int Weight { get; set; }

    public Parcel(string trackingCode, string destination, int weight)
    {
        // TODO: Sett properties fra parameterne.
    }
}
