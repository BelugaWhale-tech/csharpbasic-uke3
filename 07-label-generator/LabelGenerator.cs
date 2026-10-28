
public class LabelGenerator
{
    public string CreateLabel(string rawText)
    {
        
        return "LABEL: "+ Normalize(rawText);
    }

    private string Normalize(string rawText)
    {
        
        return rawText.ToUpper().Trim();
    }
}
