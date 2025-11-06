
using System.Diagnostics.Tracing;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

public class Word{
    private List<string> _words = new List<string>();

    private string _hiddenWord;

    private int RandomIndex()
    {
        Random random = new Random();
        int length = _words.Count();
        //Console.WriteLine(length);
        int randomIndex = random.Next(0, length);
        //Console.Write(randomIndex);
        return randomIndex;
    }
        private void SplitWords(string text)
    {
        _words.Clear();
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            _words.Add(word);
            //Console.WriteLine(_words.Count());
        }
    }
    public void HideWord(int timesRun, string text)
    {
        _words.Clear();
        SplitWords(text);

        while (timesRun != 0)
        {
            int index = RandomIndex();
            //Console.Write(index);
            _hiddenWord = _words[index];
            

            foreach (char letter in _hiddenWord)
            {
                {
                    if (letter == '_')
                    {

                    }
                    else
                    {
                        int length = _hiddenWord.Count();

                        _words[index] = new String('_', length);
                        timesRun = timesRun - 1;
                    }
                    break;
                }
            }
        }
        
    }

    public string Getter()
    {
        string _text = "";
        
        foreach (string word in _words)
        {

            if (word == _words[0])
            {
                _text = _text + word + " ";
            }

            else if (word == _words[1])
            {
                _text = _text + word;
            } 

            else
            {
                _text = _text + " " + word;
            }
            
        }
        return _text;
    }
}