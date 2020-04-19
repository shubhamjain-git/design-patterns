namespace DesignPatternsLibrary.Decorator.StartbuzzCoffee
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf Coffee";
        }

        public override float Cost()
        {
            return 1.05f;
        }
    }
}
