class Program
{
    static void Main()
    {
        PrintTransmission("System ready");
        PrintTransmission("Dock", "Gate unlocked");
        
        // TODO: Kall også din tredje overload.
        PrintTransmission("Kitchen", "we ran out of baked beans",false);
        PrintTransmission("High Command","WE ARE VERY MUCH OUT OF BAKED BEANS", true);
    }

    static void PrintTransmission(string message)
    {
        Console.WriteLine($"[UNKNOWN] {message}");
    }

    static void PrintTransmission(string sender, string message)
    {
        Console.WriteLine($"[{sender}] {message}");
    }

    static void PrintTransmission(string sender, string message, bool isPriority)
    {   if (isPriority == true)
        {
            Console.WriteLine($"[URGENT MESSAGE]: {sender}: {message}");
        }
        else
        { 
            Console.WriteLine($"[{sender}] {message}"); 
        }
    }
}