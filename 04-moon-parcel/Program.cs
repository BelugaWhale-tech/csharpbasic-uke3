Parcel first = new Parcel("MX-101", "Luna Station", 12);
Parcel second = new Parcel("MX-102", "Crater Lab", 7);

Console.WriteLine($"{first.TrackingCode} -> {first.Destination} ({first.Weight} kg)");
Console.WriteLine($"{second.TrackingCode} -> {second.Destination} ({second.Weight} kg)");
