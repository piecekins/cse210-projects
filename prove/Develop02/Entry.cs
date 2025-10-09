public class Entry
{
    public string _date;

    public string _prompt;

    public string _userInput;

    public string _entry;

    public List<string> entries = new List<string>();

    public void DisplayEntries()
    {
        foreach (string entry in entries)
        {
            Console.WriteLine(entry);
        }
    }
    public void EntryMaker()
    {
        _entry = $"Date: {_date} - Prompt: {_prompt}{Environment.NewLine}{_userInput}";
        entries.Add(_entry);
    }


}