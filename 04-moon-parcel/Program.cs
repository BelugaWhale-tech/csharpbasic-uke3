Parcel first = new Parcel("MX-101", "Luna Station", 12);
Parcel second = new Parcel("MX-102", "Crater Lab", 7);
Parcel third = new Parcel("MX-103", "Mars Parcel",21);
Parcel fourth = new Parcel("MX-104","Neptune Industries",9);
Parcel fifth = new Parcel("MX-105","Terra",9);


Console.WriteLine($"{first.TrackingCode} -> {first.Destination} ({first.Weight} kg)");
Console.WriteLine($"{second.TrackingCode} -> {second.Destination} ({second.Weight} kg)");
Console.WriteLine($"{third.TrackingCode} -> {third.Destination} ({third.Weight}kg)");
Console.WriteLine($"{fourth.TrackingCode} -> {fourth.Destination} ({fourth.Weight}kg)");
Console.WriteLine($"{fifth.TrackingCode} -> {fifth.Destination} ({fifth.Weight}kg)");



