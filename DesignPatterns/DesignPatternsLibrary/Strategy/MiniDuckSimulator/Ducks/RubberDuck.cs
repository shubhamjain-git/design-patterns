using System;

namespace DesignPatternsLibrary.Strategy.MiniDuckSimulator
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Squeak();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Rubber Duck!");
        }
    }
}
