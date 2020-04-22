namespace DesignPatternsLibrary
{
    public class DesignPatternSummaryProvider
    {
        public DesignPatternSummary GetSummary(string pattern)
        {
            DesignPatternSummary summary;
            switch (pattern)
            {
                case DesignPatternConstants.SINGLETON:
                    summary = new DesignPatternSummary
                    {
                        Name = "The Singleton Pattern",
                        Definition = "The Singleton Pattern ensures a class has only one instance,"
                            + " and provides a global point of access to it.",
                        Example = "Chocolate Factory"
                    };
                    return summary;

                case DesignPatternConstants.STRATEGY:
                    summary = new DesignPatternSummary
                    {
                        Name = "The Strategy Pattern",
                        Definition = "The Strategy Pattern defines a family of algorithms, encapsulates each one,"
                            + " and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.",
                        Example = "Mini Duck Simulator"
                    };
                    return summary;

                case DesignPatternConstants.OBSERVER:
                    summary = new DesignPatternSummary
                    {
                        Name = "The Observer Pattern",
                        Definition = "The Observer Pattern defines one-to-many dependency between objects so that"
                            + " when one object changes state, all of its dependents are notified and updated automatically.",
                        Example = "Weather Station"
                    };
                    return summary;

                case DesignPatternConstants.DECORATOR:
                    summary = new DesignPatternSummary
                    {
                        Name = "The Decorator Pattern",
                        Definition = "The Decorator Pattern attaches additional responsibilities to an object dynamically."
                            + " Decorators provide a flexible alternative to subclassing for extending functionality.",
                        Example = "Starbuzz Coffee"
                    };
                    return summary;

                case DesignPatternConstants.SIMPLE_FACTORY:
                    summary = new DesignPatternSummary
                    {
                        Name = "The Simple Factory",
                        Definition = "The Simple Factory isn't actually a Design Paaterm; it's more of a programming idiom.",
                        Example = "Pizza Store (Only one store)"
                    };
                    return summary;

                case DesignPatternConstants.FACTORY_METHOD:
                    summary = new DesignPatternSummary
                    {
                        Name = "The Factory Method Pattern",
                        Definition = "The Factory Method Pattern defines an interface for creating an object,"
                            + " but lets subclasses decide which class to intantiate."
                            + " Factory method lets a class defer instantiation to subclasses.",
                        Example = "Pizza Store (Multiple stores in different cities"
                    };
                    return summary;

                case DesignPatternConstants.ABSTRACT_FACTORY:
                    summary = new DesignPatternSummary
                    {
                        Name = "The Abstract Factory Pattern",
                        Definition = "The Abstract Factory Pattern providdes an interface for creating families of related or dependent objects"
                            + " without specifying their concrete classes.",
                        Example = "Pizza Ingredient Factory"
                    };
                    return summary;

                case DesignPatternConstants.COMMAND:
                    summary = new DesignPatternSummary
                    {
                        Name = "The Command Pattern",
                        Definition = "The Command Pattern encapsulates a request as an object, thereby let you parameterize other objects"
                            + " with different requests, queue or log requests, and support undoable operations.",
                        Example = "Remote Control"
                    };
                    return summary;

                case DesignPatternConstants.ADAPTER:
                    summary = new DesignPatternSummary
                    {
                        Name = "The Adapter Pattern",
                        Definition = "The Adapter Pattern converts the interface of a class into another interface the clients expect."
                            + " Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.",
                        Example = "Duck"
                    };
                    return summary;

                case DesignPatternConstants.FACADE:
                    summary = new DesignPatternSummary
                    {
                        Name = "The Facade Pattern",
                        Definition = "The Facade Pattern provided a unified interface to a set of interfaces in a subsystem."
                            + " Facade defines a higher-level interface that makes the subsystem easire to use.",
                        Example = "Home Theatter"
                    };
                    return summary;

                case DesignPatternConstants.TEMPLATE_METHOD:
                    summary = new DesignPatternSummary
                    {
                        Name = "The Template Method Pattern",
                        Definition = "The Template Method Pattern defines the skeleton of an algorithm in a method,"
                           + " deferring some steps to subclasses Template Method lets subclasses redefine certain steps of an algorithm"
                           + " without changing the algorithm's structure.",
                        Example = "Caffeine Beverage"
                    };
                    return summary;

                case DesignPatternConstants.ITERATOR:
                    summary = new DesignPatternSummary
                    {
                        Name = "The Iterator Pattern",
                        Definition = "The Iteartor Pattern provides a way to access the elements of an aggregate object sequentially"
                           + " without exposing its underlying representation.",
                        Example = "Diner Menu"
                    };
                    return summary;

                case DesignPatternConstants.COMPOSITE:
                    summary = new DesignPatternSummary
                    {
                        Name = "The Composite Pattern",
                        Definition = "The Composite Pattern allows you to compose object into tree structures to represent part-hole heirarchies."
                           + " Conposite lets clients treat individual objects and compositions of objects uniformly.",
                        Example = "Menu"
                    };
                    return summary;

                case DesignPatternConstants.STATE:
                    summary = new DesignPatternSummary
                    {
                        Name = "The State Pattern",
                        Definition = "The State Pattern allows an object to alter its behavior when its internal state changes."
                           + " The object will appear to change its class.",
                        Example = "Gumball Machine"
                    };
                    return summary;

                case DesignPatternConstants.PROXY:
                    summary = new DesignPatternSummary
                    {
                        Name = "The Proxy Pattern",
                        Definition = "The Proxy Pattern provides a surrogate or placeholder for another object to control access to it.",
                        Example = "Gumball Monitor"
                    };
                    return summary;

                default:
                    return null;
            }
        }
    }
}
