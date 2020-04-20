namespace DesignPatternsLibrary.Decorator.StartbuzzCoffee
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }

        public override float Cost()
        {
            float cost = 0.89f;
            if (size == Size.MEDIUM)
                return cost + 0.10f;
            if (size == Size.LARGE)
                return cost + 0.15f;
            return cost;
        }
    }
}
