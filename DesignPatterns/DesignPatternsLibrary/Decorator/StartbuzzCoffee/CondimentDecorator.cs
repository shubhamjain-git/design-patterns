namespace DesignPatternsLibrary.Decorator.StartbuzzCoffee
{
    public abstract class CondimentDecorator : Beverage
    {
        public Beverage beverage;

        public abstract override string GetDescription();

        public override Size GetSize()
        {
            return beverage.GetSize();
        }
    }
}
