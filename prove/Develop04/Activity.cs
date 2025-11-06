

class Activity
{             
    private string _activity;
    protected int _duration;
    private string _description;

    public Activity( string activity, string description)
    {
        
        _activity = activity;
        _description = description;
    }

    private void DisplayGreeting()
    {
        Console.WriteLine($"Welcome to the {_activity} Activity");
        Console.WriteLine();
        Console.WriteLine(_description);
    }

    private void SetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    protected void PauseAnimation(int seconds = 5)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        while ((startTime = DateTime.Now) < endTime)
        {

            Console.Write("-");
            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);

            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);

            Console.Write("\b \b");

        }

    }
    protected void CountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void Begin()
    {
        Console.Clear();
        Console.WriteLine();
        DisplayGreeting();
        Console.WriteLine();
        SetDuration();
        Console.Clear();

        Console.WriteLine("Get ready...");
        PauseAnimation();
        Console.WriteLine();

    }

    public void End()
    {

        Console.WriteLine("\nWell done!!!");
        PauseAnimation();
        Console.WriteLine($"\nYou have complated another {_duration} seconds of the {_activity} Activity");
        PauseAnimation();
        Console.Clear();
    }

    protected int RandomIndex(List<string> prompts)
    {
        Random random = new Random();
        int length = prompts.Count();
        //Console.WriteLine(length);
        int randomIndex = random.Next(0, length);
        //Console.Write(randomIndex);
        return randomIndex;
    }


}