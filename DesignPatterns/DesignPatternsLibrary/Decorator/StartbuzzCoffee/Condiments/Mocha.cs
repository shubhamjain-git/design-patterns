namespace DesignPatternsLibrary.Decorator.StartbuzzCoffee
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override float Cost()
        {
            float cost = beverage.Cost();
            if (beverage.GetSize() == Size.SMALL)
                cost += .20f;
            else if (beverage.GetSize() == Size.MEDIUM)
                cost += .30f;
            else if (beverage.GetSize() == Size.LARGE)
                cost += .40f;
            return cost;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Mocha";
        }
    }
}
