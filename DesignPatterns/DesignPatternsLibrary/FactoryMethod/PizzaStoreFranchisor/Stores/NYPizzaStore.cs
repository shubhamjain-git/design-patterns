namespace DesignPatternsLibrary.FactoryMethod.PizzaStoreFranchisor
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
			if (type.Equals(PizzaStoreFranchisorConstants.CHEESE_PIZZA))
			{
				return new NYStyleCheesePizza();
			}
			else if (type.Equals(PizzaStoreFranchisorConstants.VEGGIE_PIZZA))
			{
				return new NYStyleVeggiePizza();
			}
			else if (type.Equals(PizzaStoreFranchisorConstants.CLAM_PIZZA))
			{
				return new NYStyleClamPizza();
			}
			else if (type.Equals(PizzaStoreFranchisorConstants.PEPPERONI_PIZZA))
			{
				return new NYStylePepperoniPizza();
			}
			else return null;
		}
    }
}
