string path = "blackbox.txt";

// TODO: Hvis filen ikke finnes, skriv eksempeldata.
File.Exists(path);

if(File.Exists(path) == false)
{
    string data1 = "words";
    string data2 = "more words";
    string data3 = "less words";

    File.WriteAllLines(path,[data1,data2,data3]);

}
string[] newFile = File.ReadAllLines(path);
foreach(string s in newFile)
{
    Console.WriteLine(s);
}



// kjørt en gang, lager fil og skriver ut string data1, data2 og data3
// kjørt gang nr 2, skriver ut string fra fil?