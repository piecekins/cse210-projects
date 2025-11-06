class Listing : Activity
{

    private List<string> _prompts = new List<string>(
            [
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            ]
        );


    public Listing(string activity, string description) : base(activity, description)

    {

    }

    public void ItemListing()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {_prompts[RandomIndex(_prompts)]} ---");
        Console.Write("You may begin in: ");
        CountDown(5);
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
         int inputs = 0;
        while ((startTime = DateTime.Now) < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();

            inputs = inputs + 1; 
            
        }
        Console.WriteLine($"You listed {inputs} items!");
    }
}