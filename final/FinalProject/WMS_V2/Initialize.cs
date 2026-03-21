using System.Diagnostics;

class Initialize
{
    /*
    Initialize values like CSV location and number of possible surges by reading from a config file
    */
    private string[] _lines = File.ReadAllLines("Settings.config");
    public Initialize()
    {
        string[] _lines = File.ReadAllLines("Settings.config");

    }
    public string GetPath() 
    { 
        Console.WriteLine("\nPath: " + _lines[0]);
        return _lines[0];
    }
    public int GetHistoryLength() 
    { 
        Console.WriteLine("History Length: " + _lines[1]);
        return int.Parse(_lines[1]);
    }
}