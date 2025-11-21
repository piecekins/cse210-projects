
class Simple : Goal
{


    public Simple(string name, string description, int points, bool completed) : base(name, description, points, completed)
    {
        
    }

        public override void DisplayGoal()
    {   

        {
            if (_completed == false)
            {
                Console.WriteLine($" [ ] {_name} ({_description})");
            }
            else
            {
                Console.WriteLine($" [X] {_name} ({_description})");
            }
            
        }
        
    }

    public override int RecordEvent(int _totalPoints)
    {
        if (_completed == false)
        {
            _completed = true;
        }
        _totalPoints = _totalPoints + _points;
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        Console.WriteLine($"You have {_totalPoints} points.");
        return _totalPoints;
    
    }

}