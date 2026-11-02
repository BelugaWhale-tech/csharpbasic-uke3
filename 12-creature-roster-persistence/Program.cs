

using System.Runtime.InteropServices;

string path = "creatures.txt";
File.Exists(path);

List<Creature> creatures = new List<Creature>
{
    new Creature("Mora", "Lumen Fox", 72),
    new Creature("Kip", "Dust Eel", 18),
    new Creature("Senn", "Cloud Moth", 41)
};


List<string> fileLines = new List<string>();
foreach(Creature i in creatures)
{
    fileLines.Add(i.ToFileLine());

}  
File.WriteAllLines(path,fileLines);

string[] newFile = File.ReadAllLines(path);
List<Creature> loadedCreatures = new List<Creature>();
foreach(string s in newFile)
{
    string[] parts = s.Split('|');
    if (parts.Length != 3)
    {
        continue;
    }
    int e;
    if(!int.TryParse(parts[2], out e))
    {
        continue;
    }
    loadedCreatures.Add(new Creature(parts[0],parts[1],e));

}
    foreach(var c in loadedCreatures)
    {
        Console.WriteLine(c.ToFileLine());
    }
    


// TODO: Konverter objektene til linjer og skriv dem til fil.
// TODO: Les filen.
// TODO: Rekonstruer gyldige Creature-objekter i en ny liste.
// TODO: Skriv resultatet.
