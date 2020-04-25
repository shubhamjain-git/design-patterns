using System;
using System.Text;

namespace DesignPatternsLibrary.AbstractFactory.PizzaIngredientFactory
{
    public abstract class Pizza
    {
        protected string Name;

        protected IDough Dough;
        protected ISauce Sauce;
        protected IVeggies[] Veggies;
        protected ICheese Cheese;
        protected IPepperoni Pepperoni;
        protected IClams Clam;

        public abstract void Prepare();

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public override string ToString()
        {
            StringBuilder display = new StringBuilder();
            display.Append("---- " + Name + " ----\n");
            if(Dough != null)
                display.Append(Dough + "\n");
            if(Sauce != null)
                display.Append(Sauce + "\n");
            if(Cheese != null)
                display.Append(Cheese + "\n");
            if(Pepperoni != null)
                display.Append(Pepperoni + "\n");
            if(Clam != null)
                display.Append(Clam + "\n");
            if (Veggies != null)
                foreach (IVeggies veggie in Veggies)
                    display.Append(veggie + "\n");
            return display.ToString();
        }
    }
}
