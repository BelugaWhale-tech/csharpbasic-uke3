public class Creature
{
    public string Name { get; set; }
    public string Species { get; set; }
    public int Energy { get; set; }

    public Creature(string name, string species, int energy)
    {
        Name = name;
        Species = species;
        Energy = energy;
    }

    // TODO: Det er valgfritt om konvertering/parsing legges her
    // eller i egne metoder/klasser.
}
