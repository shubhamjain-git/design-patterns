using System;

namespace DesignPatternsLibrary.Strategy.MiniDuckSimulator
{
    public class ReadheadDuck : Duck
    {
        public ReadheadDuck()
        {
            flyBehavior = new FlyWithWings();
            quackBehavior = new NormalQuack();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Redhead Duck!");
        }
    }
}
