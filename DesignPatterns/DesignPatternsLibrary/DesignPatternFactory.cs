using DesignPatternsLibrary.Decorator.StartbuzzCoffee;
using DesignPatternsLibrary.Observer.WeatherStation;
using DesignPatternsLibrary.SimpleFactory.PizzaStore;
using DesignPatternsLibrary.Singleton.ChocolateBoiler;
using DesignPatternsLibrary.Strategy.MiniDuckSimulator;
using System;

namespace DesignPatternsLibrary
{
    public class DesignPatternsFactory
    {
        public static IDesignPattern GetInstance(String pattern)
        {
            switch (pattern)
            {
                case DesignPatternConstants.SINGLETON:
                    IDesignPattern chocolateBoiler = ChocolateBoiler.GetSynchronizedInstance();
                    return chocolateBoiler;

                case DesignPatternConstants.STRATEGY:
                    IDesignPattern miniDuckSimulator = new MiniDuckSimulator();
                    return miniDuckSimulator;

                case DesignPatternConstants.OBSERVER:
                    IDesignPattern weatherStation = new WeatherStation();
                    return weatherStation;

                case DesignPatternConstants.DECORATOR:
                    IDesignPattern starbuzzCoffee = new StarbuzzCoffee();
                    return starbuzzCoffee;

                case DesignPatternConstants.SIMPLE_FACTORY:
                    SimplePizzaFactory factory = new SimplePizzaFactory();
                    IDesignPattern pizzaStore = new PizzaStore(factory);
                    return pizzaStore;

                default:
                    return null;
            }
        }
    }
}
