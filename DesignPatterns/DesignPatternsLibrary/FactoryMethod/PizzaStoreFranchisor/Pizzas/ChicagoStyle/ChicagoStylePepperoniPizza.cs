﻿using System;

namespace DesignPatternsLibrary.FactoryMethod.PizzaStoreFranchisor
{
    public class ChicagoStylePepperoniPizza : Pizza
    {
		public ChicagoStylePepperoniPizza()
		{
			Name = "Chicago Style Pepperoni Pizza";
			Dough = "Extra Thick Crust Dough";
			Sauce = "Plum Tomato Sauce";

			Toppings.Add("Shredded Mozzarella Cheese");
			Toppings.Add("Black Olives");
			Toppings.Add("Spinach");
			Toppings.Add("Eggplant");
			Toppings.Add("Sliced Pepperoni");
		}

		public override void Cut()
		{
			Console.WriteLine("Cutting the pizza into square slices");
		}
	}
}
