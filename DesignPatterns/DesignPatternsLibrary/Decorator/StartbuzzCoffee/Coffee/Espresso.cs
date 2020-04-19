namespace DesignPatternsLibrary.Decorator.StartbuzzCoffee
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override float Cost()
        {
            return 1.99f;
        }
    }
}
