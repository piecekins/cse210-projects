using System.ComponentModel;
using System.Threading.Tasks.Dataflow;

class Brewer
{
    

    private List<Ingredient> _ingredientsUsed;


    public Brewer(List<Ingredient> ingredientUsed)
    {
        _ingredientsUsed = ingredientUsed;
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
                    property.SetValueMinus(ingredent.GetBuffAmount() + property.GetValueMinus());
                }
            }
            
        }
    }
    private void PropertiesMinusing(List<Property> _propertries)
    {
        foreach (Property property in _propertries)
        {


            foreach (Property badPropertry in _propertries)
            {
                
                if (badPropertry.GetNameMinus() == property.GetNameAdd())
                {
                    property.SetValueAdd(property.GetValueAdd() - badPropertry.GetValueMinus());
                }
            }

            foreach (Ingredient ingredient in _ingredientsUsed)
            {
                if (ingredient.GetDebuffProperty() == property.GetNameAdd())
                {
                    property.SetValueAdd(property.GetValueAdd() - ingredient.GetBuffAmount());
                }
            }
        }
    }

    public List<Property> Mixer(List<Ingredient> _ingredients, List<Property> _propertries)
    {   

        Console.Clear();
        int i = 0;
        int _userInput = 0;
        Console.Write("How many ingredents do you want to add: ");
        _userInput = int.Parse(Console.ReadLine());
        while (i < _userInput)
        {

            if (_ingredients.Count() == 0)
            {
                Console.WriteLine("No ingredients to add.");
                break;
            }
            bool _isInList = false;
            if (i == 0)
            {
                Console.WriteLine();
            
                foreach (Ingredient ingredient in _ingredients)
                {
                    ingredient.ShowIngredient();
                }
                Console.WriteLine();
            }
            
            while ( _isInList == false)
            {
                Console.Write("What is the name of your ingredent: ");
                string value = Console.ReadLine();
                foreach (Ingredient ingredient in _ingredients)
                {
                    if (ingredient.GetName().ToLower() == value.ToLower())
                    {
                        _isInList = true;
                        _ingredientsUsed.Add(ingredient);
                        break;
                    }
                }
                
                if (_isInList == false)
                {
                    Console.WriteLine("Unknown ingredent, please try again.\n");
                }
            }
            i = i + 1;

        }
        if(i == 0)
        {
            Console.WriteLine("Must use an ingredient");
        }
        else
        {
        PropertiesAdding(_propertries);
        PropertiesMinusing(_propertries);
        }
        _ingredientsUsed.Clear();
        return _propertries;
    }




}