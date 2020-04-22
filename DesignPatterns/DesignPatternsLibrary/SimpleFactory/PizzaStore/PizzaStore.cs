using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsLibrary.SimpleFactory.PizzaStore
{
    public class PizzaStore : IDesignPattern
    {
        private readonly SimplePizzaFactory factory;

        public PizzaStore(SimplePizzaFactory factory)
        {
            this.factory = factory;
            Console.WriteLine("Welcome to SAM Pizza Store!");
        }

        public Pizza OrderPizza(String type)
        {
            Pizza pizza;
            pizza = factory.CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        public void RunExample()
        {
            Pizza pizza = OrderPizza("cheese");
            Console.WriteLine(pizza.GetName() + " was ordered\n");
            Console.WriteLine(pizza);

            pizza = OrderPizza("veggie");
            Console.WriteLine(pizza.GetName() + " was ordered\n");
            Console.WriteLine(pizza);
        }
    }
}
