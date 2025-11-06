
class Breathing : Activity
{

    public Breathing(string activity, string description) : base(activity, description)
    {

    }
    private void BreathAnimation( bool _breath = true,int seconds = 5)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int speed = 250;
        if (_breath)
        {
            speed = 250;
        }
        else
        {
            speed = 700;
        }
        
        while ((startTime = DateTime.Now) < endTime)
        {
            if (_breath)
            {
                Console.Write("-");
                Thread.Sleep(speed);
                speed = speed + 50;
            }
            else
            {
                Console.Write("-");
                Thread.Sleep(speed);
                speed = speed - 50;
            }
            

        }
    }
    public void Breath()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while ((startTime = DateTime.Now) < endTime)
        {

            Console.WriteLine();
            Console.WriteLine("Breath in...");
            BreathAnimation();
            Console.WriteLine();
            Console.WriteLine("Now breath out...");
            BreathAnimation(false);
            Console.WriteLine();
            
        }
    }
    
    



}