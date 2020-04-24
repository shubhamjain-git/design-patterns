namespace DesignPatternsLibrary.FactoryMethod.PizzaStoreFranchisor
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            if (type.Equals(PizzaStoreFranchisorConstants.CHEESE_PIZZA))
            {
                return new ChicagoStyleCheesePizza();
            }
            else if (type.Equals(PizzaStoreFranchisorConstants.VEGGIE_PIZZA))
            {
                return new ChicagoStyleVeggiePizza();
            }
            else if (type.Equals(PizzaStoreFranchisorConstants.CLAM_PIZZA))
            {
                return new ChicagoStyleClamPizza();
            }
            else if (type.Equals(PizzaStoreFranchisorConstants.PEPPERONI_PIZZA))
            {
                return new ChicagoStylePepperoniPizza();
            }
            else return null;
        }
    }
}
