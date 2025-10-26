
public class Scripture
{
    
    private string _text;


    public void Setter(string text)
    {
        _text = text;
    }

    public string Getter()
    {
        return _text;
    }


    public void Display()
    {
        Console.WriteLine(_text);

    }
    
    public string hiddenChecker()
    {   
        bool allHidden = true;
        foreach (char letter in _text)
        {
            if (letter == '_')
            {

            }
            else if (letter == ' ')
            {

            }
            else
            {
                //Console.Write("fluas");
                allHidden = false;
            }

        }
        if (allHidden)
        {
            string end = "quit";
            return end;
        }
        else
        {
            string end = "";
            return end;
        }
            
    }
}