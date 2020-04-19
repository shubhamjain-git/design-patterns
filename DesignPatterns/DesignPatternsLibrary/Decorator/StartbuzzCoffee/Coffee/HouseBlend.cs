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
            return 0.89f;
        }
    }
}
