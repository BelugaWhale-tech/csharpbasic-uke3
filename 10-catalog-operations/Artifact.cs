public class Artifact
{
    public string Name { get; set; }
    public string Origin { get; set; }

    public Artifact(string name, string origin)
    {
        Name = name;
        Origin = origin;
    }
}
