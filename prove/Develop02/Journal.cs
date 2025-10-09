using System.IO;
public class Journal
{
    public string _fileName;
    public List<string> _entries = new List<string>();


    //public void AddEntry()
    //{

    //}

    public void SaveFile()
    {
        Console.WriteLine("Name of file you would like to save too?");
        _fileName = Console.ReadLine();
        Console.WriteLine(_fileName);
        using (StreamWriter outputFile = new StreamWriter(_fileName))
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
        _fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        foreach (string line in lines)
        {
            _entries.Add(line);
        }
    }

}