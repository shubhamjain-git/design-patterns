namespace DesignPatternsLibrary.Decorator.StartbuzzCoffee
{
    public abstract class CondimentDecorator : Beverage
    {
        public new abstract string GetDescription();
    }
}
