
using System.ComponentModel.DataAnnotations;
using System.Xml.Schema;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;
    private string _reference;

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;

        _reference = $"{_book} {_chapter}:{verse}";

    }
    public Reference(string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
        _reference = $"{_book} {_chapter}:{verse}-{_endVerse}";

    }
    
    public void Display()
    {
        Console.WriteLine(_reference);
    }
}