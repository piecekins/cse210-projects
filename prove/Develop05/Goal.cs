

using System.Drawing;
using System.Globalization;

public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _completed;
    
    protected Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    protected Goal(string name, string description, int points, bool completed)
    {
        _name = name;
        _description = description;
        _points = points;
        _completed = completed;
    }


    public virtual void DisplayGoal()
    {
        {
            
        }
        
    }

    public virtual int RecordEvent(int totalPoints)
    {
        return -1;
    
    }
    public string GetName()
    {
        return _name;
    }

    public int GetPoints()
    {
        return _points;
    }
    public virtual List<string> GetStringRepresentation()
    {
         List<string> goal = new List<string>([_name, _description, _points.ToString(), _completed.ToString()]);
        
        return goal;
    }
}

