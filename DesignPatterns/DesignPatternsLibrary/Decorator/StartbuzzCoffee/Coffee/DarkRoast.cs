namespace DesignPatternsLibrary.Decorator.StartbuzzCoffee
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast Coffee";
        }

        public override float Cost()
        {
            return 0.99f;
        }
    }
}
