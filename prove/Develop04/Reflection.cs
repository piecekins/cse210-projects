using System.IO.Pipes;

class Reflection : Activity
{

    private List<string> _prompts = new List<string>(
            [
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            ]
        );

    private List<string> _questions = new List<string>(
            [
                "Why was this experience meaningful to you?",
                "Have you ever done anything like this before?",
                "How did you get started?",
                "How did you feel when it was complete?",
                "What made this time different than other times when you were not as successful?",
                "What is your favorite thing about this experience?",
                "What could you learn from this experience that applies to other situations?",
                "What did you learn about yourself through this experience?",
                "How can you keep this experience in mind in the future?"
            ]
        );



    public Reflection(string activity, string description) : base(activity, description)
    {

    }
    
    public void reflecting()
    {
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($" ---{_prompts[RandomIndex(_prompts)]} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experoence.");
        Console.Write("You may begin in: ");
        CountDown(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while ((startTime = DateTime.Now) < endTime)
        {
            Console.Write($"> {_questions[RandomIndex(_questions)]}");
            PauseAnimation(10);
            Console.WriteLine();

        }
        Console.WriteLine();
    }
}