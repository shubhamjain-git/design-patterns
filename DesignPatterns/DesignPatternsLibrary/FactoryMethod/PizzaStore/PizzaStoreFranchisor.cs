using System;

namespace DesignPatternsLibrary.FactoryMethod.PizzaStore
{
    public class PizzaStoreFranchisor : IDesignPattern
    {
        public PizzaStoreFranchisor()
        {
            RunExample();
        }

        public PizzaStore GetFranchise(string cityName)
        {
            PizzaStore store = null;
            if(cityName.Equals("New York"))
            {
                store = new NYPizzaStore();
            }
            else if (cityName.Equals("Chicago"))
            {
                store = new ChicagoPizzaStore();
            }
            return store;
        }

        public void RunExample()
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a " + pizza.GetName() + "\n");

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine("Joel ordered a " + pizza.GetName() + "\n");

            pizza = nyStore.OrderPizza("clam");
            Console.WriteLine("Ethan ordered a " + pizza.GetName() + "\n");

            pizza = chicagoStore.OrderPizza("clam");
            Console.WriteLine("Joel ordered a " + pizza.GetName() + "\n");

            pizza = nyStore.OrderPizza("pepperoni");
            Console.WriteLine("Ethan ordered a " + pizza.GetName() + "\n");

            pizza = chicagoStore.OrderPizza("pepperoni");
            Console.WriteLine("Joel ordered a " + pizza.GetName() + "\n");

            pizza = nyStore.OrderPizza("veggie");
            Console.WriteLine("Ethan ordered a " + pizza.GetName() + "\n");

            pizza = chicagoStore.OrderPizza("veggie");
            Console.WriteLine("Joel ordered a " + pizza.GetName() + "\n");
        }
    }
}
