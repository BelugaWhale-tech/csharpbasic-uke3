public class Beacon
{
    public int Frequency { get; set; }
    public static int CreatedCount { get; private set; }

    public Beacon(int frequency)
    {
        Frequency = frequency;
    
        CreatedCount++;

        //frequency ville vært feil som static siden det er en variabel(?) som endres avhengig av hvor mange beacons som lages? 
        //problem mellom skjerm og tastatur, frequency ville vært feil som static siden vær instanse av beacon trenger sin egen frequency
        // CreatedCount deles av alle beacons så den kan være static? 
    }
}
