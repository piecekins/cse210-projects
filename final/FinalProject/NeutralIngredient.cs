class NeutralIngredient : Ingredient
{
    public NeutralIngredient(string name, string buffProperty, int buffAmount) : base(name, buffProperty, buffAmount)
    {
        
    }
    public override int GetDebuffAmount()
    {
        return 0;
    }
    public override string GetDebuffProperty()
    {
    return "";
    }
}