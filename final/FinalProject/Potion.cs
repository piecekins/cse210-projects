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
        Console.WriteLine($"\n{_name}");
        Console.WriteLine("\nPropertries");
        foreach (Property property in _propertries)
        {
            Console.WriteLine($"{property.GetNameAdd()}: {property.GetValueAdd()}");
        }
    }
    public void PotionClear()
    {
        foreach (Property property in _propertries)
                {
                    property.PropertryClear();
                }
    }
    
}