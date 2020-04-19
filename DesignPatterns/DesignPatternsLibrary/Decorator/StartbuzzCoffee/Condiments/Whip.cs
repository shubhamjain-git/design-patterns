namespace DesignPatternsLibrary.Decorator.StartbuzzCoffee
{
    public class Whip : CondimentDecorator
    {
        private readonly Beverage beverage;

        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override float Cost()
        {
            return beverage.Cost() + 0.10f;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }
    }
}
