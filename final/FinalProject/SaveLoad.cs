class SaveLoad
{   
    List<Ingredient> _ingredients = new List<Ingredient>();
    List<Property> _properties = new List<Property>();
    
    public void IngredientSetter(List<Ingredient> ingredients)
    {
        _ingredients = ingredients;
    }
    
    public List<Ingredient> IngredientGetter()
    {
        return _ingredients;
    }

    public void PropertrySetter(List<Property> properties)
    {
        _properties = properties;
    }
    
    public List<Property> PropertryGetter()
    {
        return _properties;
    }
    
    public void SaveIngredent()
    {
        using (StreamWriter outputFile = new StreamWriter("ingredient.txt"))
        {   
            foreach (Ingredient ingredient in _ingredients)
            {
                
                foreach (string element in ingredient.GetStringRepresentation())
                {
                    outputFile.Write($"{element},");
                }
               outputFile.WriteLine(); 
            }
            
        }
    }

    public void LoadIngredent()
    {
        _ingredients.Clear();
        string[] lines = System.IO.File.ReadAllLines("ingredient.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            if (parts.Count() == 3)
            {
                NeutralIngredient ingredient = new NeutralIngredient(parts[0], parts[1], int.Parse(parts[2]));  
                _ingredients.Add(ingredient);
            }

            else if (parts.Count() == 4)
            {
                GoodIngredient ingredient = new GoodIngredient(parts[0], parts[1], int.Parse(parts[2]), parts[3]);
                _ingredients.Add(ingredient);
            }
            
        }
    }
        public void SavePropertry()
    {
        using (StreamWriter outputFile = new StreamWriter("propertries.txt"))
        {   
            foreach (Property property in _properties)
            {
                
                foreach (string element in property.GetStringRepresentation())
                {
                    outputFile.Write($"{element},");
                }
               outputFile.WriteLine(); 
            }
            
        }
    }

    public void LoadPropertry ()
    {
        _properties.Clear();
        string[] lines = System.IO.File.ReadAllLines("propertries.txt");
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");


            Property propertry = new Property(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[3]));  
            _properties.Add(propertry);
            
        }
    }
    
}