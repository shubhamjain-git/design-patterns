namespace DesignPatternsLibrary.Decorator.StartbuzzCoffee
{
    public class Soy : CondimentDecorator
    {
        private readonly Beverage beverage;

        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override float Cost()
        {
            return beverage.Cost() + 0.15f;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }
    }
}
