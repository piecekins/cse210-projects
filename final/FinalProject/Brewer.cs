using System.ComponentModel;

class Brewer
{
    

    private List<Ingredient> _ingredientsUsed;


    public Brewer()
    {

    }

    private void PropertiesAdding(List<Property> _propertries)
    {
        foreach (Property property in _propertries)
        {
            foreach (Ingredient ingredent in _ingredientsUsed)
            {
                if (ingredent.GetBuffProperty().ToLower() == property.GetNameAdd().ToLower())
                {
                    property.SetValueAdd(ingredent.GetBuffAmount() + property.GetValueAdd());
                    property.SetValueMinus(ingredent.GetDebuffAmount() + property.GetValueMinus());
                }
            }
            
        }
    }
    private void PropertiesMinusing(List<Property> _propertries)
    {
        foreach (Property property in _propertries)
        {
            foreach (Ingredient ingredent in _ingredientsUsed)
            {
                if (ingredent.GetDebuffProperty().ToLower() == property.GetNameAdd().ToLower())
                {
                    property.SetValueAdd(property.GetValueAdd() - ingredent.GetDebuffAmount());

                }
            }
            foreach (Property badPropertry in _propertries)
            {
                if (badPropertry.GetNameMinus() == property.GetNameAdd())
                {
                    property.SetValueAdd(property.GetValueAdd() - badPropertry.GetValueMinus());
                    property.SetValueMinus(0);
                }
            }
        }
    }

    public List<Property> Mixer(List<Ingredient> _ingredients, List<Property> _propertries)
    {   
        
        int i = 1;
        Console.Write("How many ingredents do you want to add: ");
        while (i < int.Parse(Console.ReadLine()))
        {
            bool _isInList = false;
            if (i == 1)
            {
                foreach (Ingredient ingredient in _ingredients)
                {
                    ingredient.ShowIngredient();
                }
            }
            
            while ( _isInList == false)
            {
                Console.Write("What is the name of your ingredent");
                string value = Console.ReadLine();
                foreach (Ingredient ingredient in _ingredients)
                {
                    if (ingredient.GetName().ToLower() == value.ToLower())
                    {
                        _isInList = true;
                        _ingredientsUsed.Add(ingredient);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Unknown ingredent, please try again.");
                    }
                }
            }
            i = i + 1;
        }
        PropertiesAdding(_propertries);
        PropertiesMinusing(_propertries);
        return _propertries;
    }




}