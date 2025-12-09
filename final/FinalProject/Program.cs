using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello FinalProject World!");
        string userInput = "0";

        SaveLoad saveLoad = new SaveLoad();
        List<Property> properties = saveLoad.PropertryGetter();
        List<Ingredient> ingredients = saveLoad.IngredientGetter();
        string value1;
        string value2;
        int value3;
        string value4;       
        bool inPropertries = false;
          while (userInput != "8")
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("  1. Brew Potion");
            Console.WriteLine("  2. Make Property");
            Console.WriteLine("  3. Add ingredent");
            Console.WriteLine("  4. Show Properties");
            Console.WriteLine("  5. Show ingredents");            
            Console.WriteLine("  6. Save");
            Console.WriteLine("  7. Load");
            //Console.WriteLine("  8. Recipes");
            Console.WriteLine("  8. Quit");
            Console.Write("Select a choice from the menu: ");
            userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Brewer brewer = new Brewer();
                //brewer.Mixer(ingredients, properties);
            }
        
            else if (userInput == "2")
            {
              Console.WriteLine("\nWhat is the name of the property: ");
              value1 = Console.ReadLine();
              Console.WriteLine("\nWhat is the name of the property that this minus': ");
              value2 = Console.ReadLine();
              Property property = new Property(value1, value2);
              properties.Add(property);
            }
            
            else if(userInput == "3")
            {
                if (properties.Count() == 0)
                {
                    Console.WriteLine("It seems you have no properties to give your ingredents, please load some or add some.\n");
                }
                else
                {   
                    Console.WriteLine("\nWhat is the name of the ingredent? ");
                    value1 = Console.ReadLine();
                    Console.WriteLine();

                    int i = 1;
                    foreach(Property property in properties)
                    {
                        Console.WriteLine($"{i}: {property.GetNameAdd()}");
                        i = 1 + i;
                    }
                    Console.WriteLine("\nWhat property does this ingredient buff? ");
                    value2 = Console.ReadLine();
                    while (inPropertries == false)
                    {
                        
                        foreach (Property property in properties)
                        {
                            if (property.GetNameAdd().ToLower() == value2.ToLower())
                            {
                                inPropertries = true;
                            }
                            
                        }
                        
                        if (inPropertries)
                        {
                            break;
                        }
                        Console.WriteLine("Unknown propertry, please try again.");
                        Console.WriteLine("\nWhat property does this ingredient buff? ");
                        value2 = Console.ReadLine();
                        
                    }
                    
                    Console.WriteLine("How much power does this ingredent give? ");
                    value3 = int.Parse(Console.ReadLine());
                    Console.WriteLine("\nDoes this ingredent have a property debuff? ");
                    if (Console.ReadLine().ToLower() == "no")
                    {
                        NeutralIngredient neutral = new NeutralIngredient(value1, value2, value3);
                        ingredients.Add(neutral);
                    }
                    else
                    {
                         i = 1;
                        foreach(Property property in properties)
                        {
                        Console.WriteLine($"{i}: {property.GetNameAdd()}");
                        i = 1 + i;
                        }

                    
                        while (inPropertries == false)
                        {
                            Console.WriteLine("\nWhat property does this ingredent debuff? ");
                            value4 = Console.ReadLine();
                            foreach (Property property in properties)
                            {
                                if (property.GetNameAdd().ToLower() == value2.ToLower())
                                {
                                    inPropertries = true;
                                }
                                
                            }
                            if (inPropertries)
                            {
                                break;
                            }
                            Console.WriteLine("Unknown propertry, please try again.");
                        }
                        value4 = Console.ReadLine();
                            
                        GoodIngredient good = new GoodIngredient(value1, value2, value3, value4);
                        ingredients.Add(good);
                    }
                    
                    
                }
            }

            else if(userInput == "4")
            {
                int i = 1;
                foreach(Property propertry in properties)
                {
                    Console.Write($"{i}: "); 
                    propertry.ShowPropertry();
                    i = i + 1;
                }
            }

            else if(userInput == "5")
            {
                int i = 1;
                foreach(Ingredient ingredient in ingredients)
                {
                    Console.Write($"{i}: "); 
                    ingredient.ShowIngredient();
                    i = i + 1;
                }
            }

            else if(userInput == "6")
            {
                saveLoad.IngredientSetter(ingredients);
                saveLoad.PropertrySetter(properties);
                saveLoad.SaveIngredent();
                saveLoad.SavePropertry();
                Console.WriteLine("Saved");
            }

            else if(userInput == "7")
            {
                saveLoad.LoadIngredent();
                saveLoad.LoadPropertry();
                properties = saveLoad.PropertryGetter();
                ingredients = saveLoad.IngredientGetter();
                Console.WriteLine("Loaded");
            }

            //else if(userInput == "8")
            //{
            
            // }
            Console.WriteLine();
        }
           
    }
    
}
