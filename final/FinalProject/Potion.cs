class Potion
{
    private List<Property> _propertries;
    private string _name;

    public Potion(string name, List<Property> propertries)
    {
        _propertries = propertries;
        _name = name;
    }


    public void DisplayPotion()
    {
        foreach (Property property in _propertries)
        {
            Console.WriteLine($"{property.GetNameAdd}: {property.GetValueAdd}");
        }
    }
    
}