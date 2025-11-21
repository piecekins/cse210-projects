
class Checklist : Goal
{

    private int _timesDone;
    private int _timesNeeded;
    private int _bonus;

        public Checklist(string name, string description, int points, bool completed, int timesNeeded, int timesDone, int bonus) : base(name, description, points, completed)
    {
        _timesNeeded = timesNeeded;
        _timesDone = timesDone;
        _bonus = bonus;
    }

        public override void DisplayGoal()
    {   

        
            
            if (_completed == false)
            {
                Console.Write($" [ ] {_name} ({_description})");
            }
            else
            {
                Console.Write($" [X] {_name} ({_description})");
            }

            Console.WriteLine($" --- Currently completed: {_timesDone}/{_timesNeeded}"); 
        
        
    }
    
    public override int RecordEvent(int _totalPoints)
    {   
        if (_completed == false)
        {
            _timesDone = _timesDone + 1;

        
            if (_timesNeeded == _timesDone)
            {
                _completed = true;

                _points = _points + _bonus;
            }
            _totalPoints = _totalPoints + _points;
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            Console.WriteLine($"You have {_totalPoints} points.");

            
        }
        return _totalPoints;

    }
    public override List<string> GetStringRepresentation()
    {
         List<string> goal = new List<string>([_name, _description, _points.ToString(), _completed.ToString(), _timesNeeded.ToString(), _timesDone.ToString(), _bonus.ToString()]);
        
        return goal;
    }
}