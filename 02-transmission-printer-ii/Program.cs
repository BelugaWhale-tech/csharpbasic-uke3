class Program
{
    static void Main()
    {
        PrintTransmission("System ready");
        PrintTransmission("Dock", "Gate unlocked");
        
        // TODO: Kall også din tredje overload.
        
        PrintTransmission("High Command","We ran out of beans", true);
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