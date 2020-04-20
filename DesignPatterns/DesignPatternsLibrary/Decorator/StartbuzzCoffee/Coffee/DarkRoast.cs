namespace DesignPatternsLibrary.Decorator.StartbuzzCoffee
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast Coffee";
        }

        public override float Cost()
        {
            float cost = 0.99f;
            if (size == Size.MEDIUM)
                return cost + 0.10f;
            if (size == Size.LARGE)
                return cost + 0.15f;
            return cost;
        }
    }
}
