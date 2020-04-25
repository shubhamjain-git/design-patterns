namespace DesignPatternsLibrary.AbstractFactory.PizzaIngredientFactory
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string item)
        {
			Pizza pizza = null;
			IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

			if (item.Equals(PizzaIngredientFactoryConstants.CHEESE_PIZZA))
			{
				pizza = new CheesePizza(ingredientFactory);
				pizza.SetName("New York Style Cheese Pizza");
			}
			else if (item.Equals(PizzaIngredientFactoryConstants.VEGGIE_PIZZA))
			{
				pizza = new VeggiePizza(ingredientFactory);
				pizza.SetName("New York Style Veggie Pizza");
			}
			else if (item.Equals(PizzaIngredientFactoryConstants.CLAM_PIZZA))
			{ 
				pizza = new ClamPizza(ingredientFactory);
				pizza.SetName("New York Style Clam Pizza");
			}
			else if (item.Equals(PizzaIngredientFactoryConstants.PEPPERONI_PIZZA))
			{
				pizza = new PepperoniPizza(ingredientFactory);
				pizza.SetName("New York Style Pepperoni Pizza");
			}
			return pizza;

		}
	}
}
