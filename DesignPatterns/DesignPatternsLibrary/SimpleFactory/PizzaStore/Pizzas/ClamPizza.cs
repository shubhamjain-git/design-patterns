﻿namespace DesignPatternsLibrary.SimpleFactory.PizzaStore
{
    public class ClamPizza : Pizza
    {
        public ClamPizza()
        {
            Name = "Clam Pizza";
            Dough = "Thin crust";
            Sauce = "White garlic sauce";
            Toppings.Add("Clams");
            Toppings.Add("Grated parmesan cheese");
        }
    }
}
