namespace DesignPatternsLibrary.Decorator.StartbuzzCoffee
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override float Cost()
        {
            float cost = 1.99f;
            if (size == Size.MEDIUM)
                return cost + 0.15f;
            if (size == Size.LARGE)
                return cost + 0.25f;
            return cost;
        }
    }
}
