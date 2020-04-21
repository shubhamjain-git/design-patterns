using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsLibrary.SimpleFactory.PizzaStore
{
    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            Name = "Cheese Pizza";
            Dough = "Regular Crust";
            Sauce = "Marinara Pizza Sauce";
            Toppings.Add("Fresh Mozzarella");
            Toppings.Add("Parmesan");
        }
    }
}
