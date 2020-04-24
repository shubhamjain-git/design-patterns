using System;

namespace DesignPatternsLibrary.SimpleFactory.PizzaStore
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(String type)
        {
            Pizza pizza = null;

            if (type.Equals(PizzaStoreConstants.CHEESE_PIZZA))
            {
                pizza = new CheesePizza();
            }
            else if (type.Equals(PizzaStoreConstants.PEPPERONI_PIZZA))
            {
                pizza = new PepperoniPizza();
            }
            else if (type.Equals(PizzaStoreConstants.CLAM_PIZZA))
            {
                pizza = new ClamPizza();
            }
            else if (type.Equals(PizzaStoreConstants.VEGGIE_PIZZA))
            {
                pizza = new VeggiePizza();
            }
            return pizza;
        }
    }
}
