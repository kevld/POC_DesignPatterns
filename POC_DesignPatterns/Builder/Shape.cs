namespace POC_DesignPatterns.Builder;

public class Shape
{
    private List<string> _config = new List<string>();

    public void AddConfigToShape(string data)
    {
        _config.Add(data);
    }

    public string GetResult()
    {
        return string.Join(' ', _config);
    }
}