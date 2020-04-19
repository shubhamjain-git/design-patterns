using System;

namespace DesignPatternsLibrary.Strategy.MiniDuckSimulator
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new NormalQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Model Duck!");
        }
    }
}
