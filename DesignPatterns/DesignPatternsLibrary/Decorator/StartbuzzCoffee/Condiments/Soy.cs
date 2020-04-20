namespace DesignPatternsLibrary.Decorator.StartbuzzCoffee
{
    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override float Cost()
        {
            float cost = beverage.Cost();
            if (beverage.GetSize() == Size.SMALL)
                cost += .15f;
            else if (beverage.GetSize() == Size.MEDIUM)
                cost += .23f;
            else if (beverage.GetSize() == Size.LARGE)
                cost += .30f;
            return cost;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Soy";
        }
    }
}
