using System;
using DesignPatternsLibrary.Decorator.StartbuzzCoffee;
using DesignPatternsLibrary.Observer.WeatherStation;
using DesignPatternsLibrary.SimpleFactory.PizzaStore;
using DesignPatternsLibrary.FactoryMethod.PizzaStore;
using DesignPatternsLibrary.Singleton.ChocolateBoiler;
using DesignPatternsLibrary.Strategy.MiniDuckSimulator;

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
                    IDesignPattern pizzaStore = new SimpleFactory.PizzaStore.PizzaStore(factory);
                    return pizzaStore;

                case DesignPatternConstants.FACTORY_METHOD:
                    IDesignPattern franchisor = new PizzaStoreFranchisor();
                    return franchisor;

                default:
                    return null;
            }
        }
    }
}
