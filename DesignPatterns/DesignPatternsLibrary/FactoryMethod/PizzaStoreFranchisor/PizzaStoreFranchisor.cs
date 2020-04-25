using System;

namespace DesignPatternsLibrary.FactoryMethod.PizzaStoreFranchisor
{
    public class PizzaStoreFranchisor : IDesignPattern
    {
        public PizzaStoreFranchisor()
        {
            Console.WriteLine("!!Welcome to PizzaStore Franchisor!!");
        }

        public PizzaStore GetFranchise(string cityName)
        {
            PizzaStore store = null;
            if(cityName.Equals(PizzaStoreFranchisorConstants.NEW_YORK))
            {
                store = new NYPizzaStore();
            }
            else if (cityName.Equals(PizzaStoreFranchisorConstants.CHICAGO))
            {
                store = new ChicagoPizzaStore();
            }
            return store;
        }

        public void RunExample()
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza(PizzaStoreFranchisorConstants.CHEESE_PIZZA);
            Console.WriteLine("Ethan ordered a " + pizza.GetName() + "\n");

            pizza = chicagoStore.OrderPizza(PizzaStoreFranchisorConstants.CHEESE_PIZZA);
            Console.WriteLine("Joel ordered a " + pizza.GetName() + "\n");

            pizza = nyStore.OrderPizza(PizzaStoreFranchisorConstants.CLAM_PIZZA);
            Console.WriteLine("Ethan ordered a " + pizza.GetName() + "\n");

            pizza = chicagoStore.OrderPizza(PizzaStoreFranchisorConstants.CLAM_PIZZA);
            Console.WriteLine("Joel ordered a " + pizza.GetName() + "\n");

            pizza = nyStore.OrderPizza(PizzaStoreFranchisorConstants.PEPPERONI_PIZZA);
            Console.WriteLine("Ethan ordered a " + pizza.GetName() + "\n");

            pizza = chicagoStore.OrderPizza(PizzaStoreFranchisorConstants.PEPPERONI_PIZZA);
            Console.WriteLine("Joel ordered a " + pizza.GetName() + "\n");

            pizza = nyStore.OrderPizza(PizzaStoreFranchisorConstants.VEGGIE_PIZZA);
            Console.WriteLine("Ethan ordered a " + pizza.GetName() + "\n");

            pizza = chicagoStore.OrderPizza(PizzaStoreFranchisorConstants.VEGGIE_PIZZA);
            Console.WriteLine("Joel ordered a " + pizza.GetName() + "\n");
        }
    }
}
