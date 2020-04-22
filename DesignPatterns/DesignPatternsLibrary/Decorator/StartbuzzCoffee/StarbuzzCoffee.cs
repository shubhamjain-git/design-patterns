using System;

namespace DesignPatternsLibrary.Decorator.StartbuzzCoffee
{
    public class StarbuzzCoffee : IDesignPattern
    {
        private Beverage beverage;

        public StarbuzzCoffee()
        {
            Console.WriteLine("Welcome to Starbuzz Coffee");
        }

        public Beverage GetBeverage(string beverageName)
        {
            switch (beverageName)
            {
                case StarbuzzCoffeeConstants.ESPRESSO:
                    beverage = new Espresso();
                    break;

                case StarbuzzCoffeeConstants.DARK_ROAST:
                    beverage = new DarkRoast();
                    break;

                case StarbuzzCoffeeConstants.DECAF:
                    beverage = new Decaf();
                    break;

                case StarbuzzCoffeeConstants.HOUSE_BELND:
                    beverage = new HouseBlend();
                    break;

                default:
                    throw new NotImplementedException();
            }
            return beverage;
        }

        public void RunExample()
        {
            Beverage beverage1 = new Espresso();
            Console.WriteLine(beverage1.GetDescription() + " $" + beverage1.Cost());

            Beverage beverage2 = new DarkRoast();
            beverage2 = new Mocha(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.GetDescription() + " $" + beverage2.Cost());

            Beverage beverage3 = new HouseBlend();
            beverage3 = new Soy(beverage3);
            beverage3 = new Mocha(beverage3);
            beverage3 = new Whip(beverage3);
            Console.WriteLine(beverage3.GetDescription() + " $" + beverage3.Cost());

            Beverage beverage4 = new HouseBlend();
            beverage4.SetSize(Beverage.Size.MEDIUM);
            beverage4 = new Soy(beverage4);
            beverage4 = new Mocha(beverage4);
            beverage4 = new Whip(beverage4);
            Console.WriteLine(beverage4.GetSize() + " " + beverage4.GetDescription() + " $" + beverage4.Cost());
        }
    }
}
