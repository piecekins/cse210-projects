
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;

class SaveLoad
{   
    private string _fileName;
    List<Goal> _goals = new List<Goal>();
    
    private int _points;
    
    public void GoalSetter(List<Goal> goals)
    {
        _goals = goals;
    }
    
    public List<Goal> GoalGetter()
    {
        return _goals;
    }
    
    public void SaveFile()
    {
        Console.WriteLine("Name of file you would like to save too?");
        _fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {   
            outputFile.WriteLine(_points);
            foreach (Goal goal in _goals)
            {
                outputFile.Write($"{goal},");
                foreach (string element in goal.GetStringRepresentation())
                {
                    outputFile.Write($"{element},");
                }
               outputFile.WriteLine(); 
            }
            
        }
    }

    public void LoadFile()
    {
        _goals.Clear();
        Console.WriteLine("Name of file you would like to load from?");
        _fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            if (parts[0] == "Simple")
            {
                Simple goal = new Simple(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));  
                _goals.Add(goal);
            }

            else if (parts[0] == "Eternal")
            {
                Eternal goal = new Eternal(parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(goal);
            }

            else if (parts[0] == "Checklist")
            {
                Checklist goal = new Checklist(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7])); 
                _goals.Add(goal);
            }
            else
            {
                PointSetter(int.Parse(line));
            }
            
        }
    }
    
    public int PointGetter()
    {
        return _points;
    }
    public void PointSetter(int totalpoints)
    {
        _points = totalpoints;
    }
}




