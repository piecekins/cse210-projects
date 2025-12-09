using System.Diagnostics.Contracts;

class Property
{
    private string _nameAdd;
    private int _valueAdd;
    private string _nameMinus;
    private int _valueMinus;

    public Property(string name, string nameMinus, int value = 0, int valueMinus = 0)
    {
        _nameAdd = name;
        _valueAdd = value;
        _valueMinus = valueMinus;
        _nameMinus = nameMinus;
    }

    public string GetNameAdd()
    {
        return _nameAdd;
    }
    public string GetNameMinus()
    {
        return _nameMinus;
    }

    public int GetValueAdd()
    {
        return _valueAdd;
    }
    public int GetValueMinus()
    {
        return _valueMinus;
    }

    public void SetValueAdd(int value)
    {
        _valueAdd = value;
    }

    public void SetValueMinus(int value)
    {
        _valueMinus = value;
    }

    public void PropertryClear(List<Property> propertries)
    {
        foreach (Property property in propertries)
        {
            property.SetValueAdd(0);
            property.SetValueMinus(0);
        }
    }

    public void ShowPropertry()
    {
        Console.WriteLine($"Adds {_nameAdd} : Minus {_nameMinus}");
    }
    public List<string> GetStringRepresentation()
    {
         List<string> propertry = new List<string>([_nameAdd, _nameMinus, _valueAdd.ToString(), _valueMinus.ToString()]);
        
        return propertry;
    }
}