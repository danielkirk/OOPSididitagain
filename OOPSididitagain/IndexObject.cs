// See https://aka.ms/new-console-template for more information
public class IndexObject
{
    private readonly Dictionary<string, string> _dictionary;
    public DateTime Expiry { get; set; }
    public IndexObject()
    {
        _dictionary = new Dictionary<string, string>();
    }

    public string this[string Key]
    {
        get { return _dictionary[Key]; }
        set { _dictionary[Key] = value; }
    }
}