Beacon one = new Beacon(101);
Beacon two = new Beacon(205);
Beacon three = new Beacon(330);

Console.WriteLine(one.Frequency);
Console.WriteLine(two.Frequency);
Console.WriteLine(three.Frequency);
Console.WriteLine($"Created: {Beacon.CreatedCount}");
