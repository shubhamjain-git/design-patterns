namespace DesignPatternsLibrary.Decorator.StartbuzzCoffee
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf Coffee";
        }

        public override float Cost()
        {
            float cost = 1.05f;
            if (size == Size.MEDIUM)
                return cost + 0.10f;
            if (size == Size.LARGE)
                return cost + 0.15f;
            return cost;
        }
    }
}
