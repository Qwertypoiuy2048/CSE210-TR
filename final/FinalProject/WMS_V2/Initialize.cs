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
        //! return "C:\\Users\\ehcre\\.vscode\\projects\\MyProjects\\WMS.csv"; 
        Console.WriteLine("Path: " + _lines[0]);
        return _lines[0];
    }
}