
List<Artifact> artifacts = new List<Artifact>();
Artifact trident = new Artifact("Neptunes Trident","The red sea",45);
Artifact skull = new Artifact("Skull of Mephisto","Papanyginea",100);
Artifact sword = new Artifact("Sword of a thousand truths", "South park",200);
Artifact beans = new Artifact("Magical beans","Yorkshire",75);
Artifact mouse = new Artifact("Packard bell wired mouse", "USSR",80);

artifacts.Add(trident);
artifacts.Add(skull);
artifacts.Add(sword);
artifacts.Add(beans);

Console.WriteLine(artifacts.Count);
foreach (Artifact i in artifacts)
{  
    Console.WriteLine($"{i.Name} {i.Origin} {i.Risk}");
}

artifacts.Add(mouse);
Console.WriteLine(artifacts.Count);
//skrive ut det nye objektet også?

