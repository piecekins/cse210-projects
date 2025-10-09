using System.ComponentModel.DataAnnotations;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();


    public string RandomPrompt()
    {
        Random randomPrompt = new Random();
        int length = _prompts.Count;
        int randomIndex = randomPrompt.Next(0, length);

        string prompt = _prompts[randomIndex];
        Console.WriteLine(prompt, randomIndex);

        return prompt;
        
    }

}