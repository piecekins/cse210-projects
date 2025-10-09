using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop02 World!");
        string manu = "-1";
        PromptGenerator promptGenerator = new PromptGenerator();
        
        Entry entry = new Entry();
        Journal journal = new Journal();
        
        promptGenerator._prompts.Add("What is the best thing that happened today?");
        promptGenerator._prompts.Add("What was the worse thing that happened today?");
        promptGenerator._prompts.Add("Did you go anywhere today?");
        promptGenerator._prompts.Add("any big news to report about?");
        promptGenerator._prompts.Add("Anything fun happen?");

        while (manu != "5")
        {
            Console.WriteLine
            ($"1. Write {Environment.NewLine}" +
             $"2. Display {Environment.NewLine}" +
             $"3. Load {Environment.NewLine}" +
             $"4. Save {Environment.NewLine}" +
             $"5. Quit {Environment.NewLine}");

            Console.Write("What would you like to do? ");
            manu = Console.ReadLine();

            if (manu == "1")
            {
                entry._prompt = promptGenerator.RandomPrompt();
                entry._userInput = Console.ReadLine();
                DateTime date = DateTime.Now;
                entry._date = date.ToShortDateString();
                entry.EntryMaker();

            }

            else if (manu == "2")
            {
                entry.DisplayEntries();
            }

            else if (manu == "3")
            {
                journal.LoadFile();
                entry.entries = journal._entries;
            }

            else if (manu == "4")
            {
                journal.SaveFile();
                entry.entries.Clear();
            }

        }
    }
}