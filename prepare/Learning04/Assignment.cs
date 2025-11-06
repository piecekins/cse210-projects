
public class Assignment
{

    protected string _studentName;
    private string _topic;

    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public string GetName()
    {
        return _studentName;
    }
    
        public string Gettopic()
    {
        return _topic;
    }
    public string GetSummary()
    {
        string summary = $"{_studentName} - {_topic}";
        return summary;
    }
}