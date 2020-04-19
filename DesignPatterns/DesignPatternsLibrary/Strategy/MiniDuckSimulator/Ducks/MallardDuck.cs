using System;

namespace DesignPatternsLibrary.Strategy.MiniDuckSimulator
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new NormalQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Mallard Duck!");
        }
    }
}
