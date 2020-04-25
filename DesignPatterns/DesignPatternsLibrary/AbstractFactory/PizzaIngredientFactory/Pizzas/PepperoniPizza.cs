using System;

namespace DesignPatternsLibrary.AbstractFactory.PizzaIngredientFactory
{
    public class PepperoniPizza : Pizza
    {
		private readonly IPizzaIngredientFactory ingredientFactory;

		public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
		{
			this.ingredientFactory = ingredientFactory;
		}

		public override void Prepare()
		{
			Console.WriteLine("Preparing " + Name);
			Dough = ingredientFactory.CreateDough();
			Sauce = ingredientFactory.CreateSauce();
			Cheese = ingredientFactory.CreateCheese();
			Veggies = ingredientFactory.CreateVeggies();
			Pepperoni = ingredientFactory.CreatePepperoni();
		}
	}
}
