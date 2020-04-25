using System;

namespace DesignPatternsLibrary.AbstractFactory.PizzaIngredientFactory
{
    public class PizzaTestDrive : IDesignPattern
    {
        public PizzaTestDrive()
        {
            Console.WriteLine("!!Welcome to Pizza Ingredient Factory!!");
        }

        public void RunExample()
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza(PizzaIngredientFactoryConstants.CHEESE_PIZZA);
            Console.WriteLine("Ethan ordered a " + pizza.GetName() + "\n");

            pizza = chicagoStore.OrderPizza(PizzaIngredientFactoryConstants.CHEESE_PIZZA);
            Console.WriteLine("Joel ordered a " + pizza.GetName() + "\n");

            pizza = nyStore.OrderPizza(PizzaIngredientFactoryConstants.CLAM_PIZZA);
            Console.WriteLine("Ethan ordered a " + pizza.GetName() + "\n");

            pizza = chicagoStore.OrderPizza(PizzaIngredientFactoryConstants.CLAM_PIZZA);
            Console.WriteLine("Joel ordered a " + pizza.GetName() + "\n");

            pizza = nyStore.OrderPizza(PizzaIngredientFactoryConstants.PEPPERONI_PIZZA);
            Console.WriteLine("Ethan ordered a " + pizza.GetName() + "\n");

            pizza = chicagoStore.OrderPizza(PizzaIngredientFactoryConstants.PEPPERONI_PIZZA);
            Console.WriteLine("Joel ordered a " + pizza.GetName() + "\n");

            pizza = nyStore.OrderPizza(PizzaIngredientFactoryConstants.VEGGIE_PIZZA);
            Console.WriteLine("Ethan ordered a " + pizza.GetName() + "\n");

            pizza = chicagoStore.OrderPizza(PizzaIngredientFactoryConstants.VEGGIE_PIZZA);
            Console.WriteLine("Joel ordered a " + pizza.GetName() + "\n");
        }
    }
}
