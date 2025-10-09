using System.IO;
public class Journal
{
    public string _filename;
    public List<string> _entries = new List<string>();


    public void AddEntry()
    {

    }

    public void SaveFile()
    {
        Console.WriteLine("Name of file you would like to save too?");
        _filename = Console.ReadLine();
        Console.WriteLine(_filename);
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (string entry in _entries)
            {
                outputFile.WriteLine(entry);
            }
        }
    }

    public void LoadFile()
    {
        Console.WriteLine("Name of file you would like to load from?");
        _filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(_filename);
        foreach (string line in lines)
        {
            _entries.Add(line);
        }
    }

}