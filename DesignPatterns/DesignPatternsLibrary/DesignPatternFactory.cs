using System;
using DesignPatternsLibrary.Decorator.StartbuzzCoffee;
using DesignPatternsLibrary.Observer.WeatherStation;
using DesignPatternsLibrary.SimpleFactory.PizzaStore;
using DesignPatternsLibrary.FactoryMethod.PizzaStoreFranchisor;
using DesignPatternsLibrary.Singleton.ChocolateBoiler;
using DesignPatternsLibrary.Strategy.MiniDuckSimulator;
using DesignPatternsLibrary.AbstractFactory.PizzaIngredientFactory;

namespace DesignPatternsLibrary
{
    public class DesignPatternsFactory
    {
        public static IDesignPattern GetInstance(String patternName)
        {
            IDesignPattern designPattern;

            switch (patternName)
            {
                case DesignPatternConstants.SINGLETON:
                    designPattern = ChocolateBoiler.GetSynchronizedInstance();
                    break;

                case DesignPatternConstants.STRATEGY:
                    designPattern = new MiniDuckSimulator();
                    break;

                case DesignPatternConstants.OBSERVER:
                    designPattern = new WeatherStation();
                    break;

                case DesignPatternConstants.DECORATOR:
                    designPattern = new StarbuzzCoffee();                    
                    break;

                case DesignPatternConstants.SIMPLE_FACTORY:
                    SimplePizzaFactory factory = new SimplePizzaFactory();
                    designPattern = new SimpleFactory.PizzaStore.PizzaStore(factory);
                    break;

                case DesignPatternConstants.FACTORY_METHOD:
                    designPattern = new PizzaStoreFranchisor();
                    break;

                case DesignPatternConstants.ABSTRACT_FACTORY:
                    designPattern = new PizzaTestDrive();
                    break;

                default:
                    throw new NotImplementedException();
            }

            return designPattern;
        }
    }
}
