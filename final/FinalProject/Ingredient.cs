
class Ingredient
{
    
    protected string _name;
    protected string _buffProperty;
    protected int _buffAmount;
    protected int _debuffAmount;
    protected string _debuffProperty;
    

    public Ingredient(string name, string buffProperty, int buffAmount)
    {
        _name = name;
        _buffProperty = buffProperty;
        _buffAmount = buffAmount;
    }

    public virtual void ShowIngredient()
    {
        Console.WriteLine($"{_name}: Buffs({_buffProperty.ToLower()}: {_buffAmount})");
    }

    public string GetName()
    {
        return _name;
    }
    public virtual int GetDebuffAmount()
    {
        return _debuffAmount;
    }
    public virtual string GetDebuffProperty()
    {
        return _debuffProperty;
    }
    public string GetBuffProperty()
    {
        return _buffProperty;
    }
    public int GetBuffAmount()
    {
        return _buffAmount;
    }

    public virtual List<string> GetStringRepresentation()
    {
         List<string> ingredient = new List<string>([_name, _buffProperty, _buffAmount.ToString()]);
        
        return ingredient;
    }
}