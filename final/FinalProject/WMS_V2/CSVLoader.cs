using System.Text.RegularExpressions;
class CSVLoader
{
    private string[] _lines;
    private int _id;
    private char _type;
    private int _power;
    private string _description;
    private string[] _values;
    private List<Surge> _surges = new List<Surge>();

    public List<Surge> LoadCSV(string path)
    {
        // TODO: Read file and create Surge objects
        _lines = File.ReadAllLines(path);
        foreach (string line in _lines)
        {
            //tmp Console.WriteLine(line);

            _id ++;
            _values = line.Split(',');;
            _type = char.Parse(_values[0]);
            _power = int.Parse(_values[1]);
            _description = _values[2];

            bool isrollable = Regex.IsMatch(_description, "[0-9]+d[0-9]+");
            if (isrollable)
            {
                Rollable surge = new Rollable(_id, _type, _power, _description,1,1,1);
                _surges.Add(surge);

            } else
            {
                Constant surge = new Constant(_id, _type, _power, _description);
                _surges.Add(surge);
            }
        }
        return _surges;
    }
}