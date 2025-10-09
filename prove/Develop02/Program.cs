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
        promptGenerator._fileName = "prompt.txt";
        
        promptGenerator._prompts.Add("What is the best thing that happened today?");
        promptGenerator._prompts.Add("What was the worse thing that happened today?");
        promptGenerator._prompts.Add("Did you go anywhere today?");
        promptGenerator._prompts.Add("any big news to report about?");
        promptGenerator._prompts.Add("Anything fun happen?");
        //prompts are in C:\Users\GAMEPOWER\Documents\byui\cse210\cse210-projects\prove\Develop02\bin\Debug\net8.0\prompt.txt
        //Entries is in C:\Users\GAMEPOWER\Documents\byui\cse210\cse210-projects\prove\Develop02\bin\Debug\net8.0\myFile.txt
        while (manu != "6")
        {
            Console.WriteLine
            ($"1. Write {Environment.NewLine}" +
             $"2. Display {Environment.NewLine}" +
             $"3. Load {Environment.NewLine}" +
             $"4. Save {Environment.NewLine}" +
             $"5. Add Prompt {Environment.NewLine}" +
             $"6. Quit {Environment.NewLine}");

            Console.Write("What would you like to do? ");
            manu = Console.ReadLine();

            if (manu == "1")
            { 
                promptGenerator.LoadPrompt();
                entry._prompt = promptGenerator.RandomPrompt();
                entry._userInput = Console.ReadLine();
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

            else if (manu == "5")
            {
                promptGenerator._prompts.Clear();
                promptGenerator.AddPrompt();
                promptGenerator.SavePrompt();
            }

        }
    }
}