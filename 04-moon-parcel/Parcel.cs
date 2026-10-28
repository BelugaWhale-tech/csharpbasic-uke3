public class Parcel
{
    public string TrackingCode { get; set; } = "";
    public string Destination { get; set; } = "";
    public int Weight { get; set; }

    public Parcel(string trackingCode, string destination, int weight)
    {
        TrackingCode=trackingCode;
        Destination=destination;
        Weight=weight;
    }
}
