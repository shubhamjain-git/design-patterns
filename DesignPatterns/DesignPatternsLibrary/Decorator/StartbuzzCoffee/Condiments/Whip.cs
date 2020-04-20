namespace DesignPatternsLibrary.Decorator.StartbuzzCoffee
{
    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override float Cost()
        {
            float cost = beverage.Cost();
            if (beverage.GetSize() == Size.SMALL)
                cost += .10f;
            else if (beverage.GetSize() == Size.MEDIUM)
                cost += .15f;
            else if (beverage.GetSize() == Size.LARGE)
                cost += .20f;
            return cost;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }
    }
}
