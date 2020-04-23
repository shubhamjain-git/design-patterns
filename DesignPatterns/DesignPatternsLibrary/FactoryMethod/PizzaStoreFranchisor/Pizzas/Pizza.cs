using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsLibrary.FactoryMethod.PizzaStore
{
    public abstract class Pizza
    {
        protected string Name;
        protected string Dough;
        protected string Sauce;
        protected List<string> Toppings = new List<string>();

        public string GetName()
        {
            return Name;
        }

        public void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings: ");
            foreach (string topping in Toppings)
            {
                Console.WriteLine("  " + topping);
            }
        }

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Placing pizza in official PizzaStore box");
        }

        public override string ToString()
        {
            StringBuilder display = new StringBuilder();
            display.Append("---- " + Name + " ----\n");
            display.Append(Dough + "\n");
            display.Append(Sauce + "\n");
            foreach (string topping in Toppings)
            {
                display.Append(topping + "\n");
            }
            return display.ToString();
        }
    }
}