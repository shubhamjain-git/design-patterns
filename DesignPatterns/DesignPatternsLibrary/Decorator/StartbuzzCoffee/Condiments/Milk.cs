namespace DesignPatternsLibrary.Decorator.StartbuzzCoffee
{
    public class Milk : CondimentDecorator
    {
        private readonly Beverage beverage;

        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override float Cost()
        {
            return beverage.Cost() + 0.10f;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Milk";
        }
    }
}
