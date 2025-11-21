
class Eternal : Goal
{

    public Eternal(string name, string description, int points) : base(name, description, points)
    {
        
    }

    public override void DisplayGoal()
    {   

                Console.WriteLine($" [ ] {_name} ({_description})");
        
    }

    public override int RecordEvent(int _totalPoints)
    {

        _totalPoints = _totalPoints + _points;
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        Console.WriteLine($"You have {_totalPoints} points.");
        return _totalPoints;
    
    }

    public override List<string> GetStringRepresentation()
    {
         List<string> goal = new List<string>([_name, _description, _points.ToString()]);
        
        return goal;
    }
}