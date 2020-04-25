using System;

namespace DesignPatternsLibrary.AbstractFactory.PizzaIngredientFactory
{
    public abstract class PizzaStore
    {
		protected abstract Pizza CreatePizza(string item);

		public Pizza OrderPizza(string type)
		{
			Pizza pizza = CreatePizza(type);
			Console.WriteLine("--- Making a " + pizza.GetName() + " ---");
			pizza.Prepare();
			pizza.Bake();
			pizza.Cut();
			pizza.Box();
			Console.WriteLine(pizza);
			return pizza;
		}
	}
}
