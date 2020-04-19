namespace DesignPatternsLibrary.Decorator.StartbuzzCoffee
{
    public class Mocha : CondimentDecorator
    {
        private readonly Beverage beverage;

        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override float Cost()
        {
            return beverage.Cost() + 0.20f;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }
    }
}
