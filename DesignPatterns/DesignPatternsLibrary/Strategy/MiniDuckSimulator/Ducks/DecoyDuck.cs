using System;

namespace DesignPatternsLibrary.Strategy.MiniDuckSimulator
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Decoy Duck!");
        }
    }
}
