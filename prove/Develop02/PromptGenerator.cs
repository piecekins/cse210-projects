using System.ComponentModel.DataAnnotations;
using System.IO;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();
    public string _fileName;

    public string RandomPrompt()
    {
        Random randomPrompt = new Random();
        int length = _prompts.Count;
        int randomIndex = randomPrompt.Next(0, length);

        string prompt = _prompts[randomIndex];
        Console.WriteLine(prompt, randomIndex);

        return prompt;

    }

    public void AddPrompt()
    {
        Console.WriteLine("What is the prompt you would like to add?");
        _prompts.Add(Console.ReadLine());
    }
    
    public void SavePrompt()
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (string prompt in _prompts)
            {
                outputFile.WriteLine(prompt);
            }
        }
    }
    
    public void LoadPrompt()
    {

        string[] lines = System.IO.File.ReadAllLines(_fileName);
        foreach (string line in lines)
        {
            _prompts.Add(line);
        }
    }

}