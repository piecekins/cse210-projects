class GoodIngredient : Ingredient
{
    

    public GoodIngredient(string name, string buffProperty, int buffAmount, string debuffProperty) : base(name, buffProperty, buffAmount)
    {
        _debuffAmount = -buffAmount;
        _debuffProperty = debuffProperty;
    }

    public override void ShowIngredient()
    {
        Console.WriteLine($"{_name}: Buffs({_buffProperty}:{_buffAmount}) and Debuffs({_debuffProperty}: -{_buffAmount})");
    }

    public override List<string> GetStringRepresentation()
    {
         List<string> ingredient = new List<string>([_name, _buffProperty, _buffAmount.ToString(), _debuffProperty]);
        
        return ingredient;
    }

}