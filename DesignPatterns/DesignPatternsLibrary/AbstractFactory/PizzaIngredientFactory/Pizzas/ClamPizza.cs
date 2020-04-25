using System;

namespace DesignPatternsLibrary.AbstractFactory.PizzaIngredientFactory
{
    public class ClamPizza : Pizza
    {
		private readonly IPizzaIngredientFactory ingredientFactory;

		public ClamPizza(IPizzaIngredientFactory ingredientFactory)
		{
			this.ingredientFactory = ingredientFactory;
		}

		public override void Prepare()
		{
			Console.WriteLine("Preparing " + Name);
			Dough = ingredientFactory.CreateDough();
			Sauce = ingredientFactory.CreateSauce();
			Cheese = ingredientFactory.CreateCheese();
			Clam = ingredientFactory.CreateClam();
		}
	}
}
