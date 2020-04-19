using System;

namespace DesignPatternsLibrary.Strategy.MiniDuckSimulator
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can'y fly!");
        }
    }
}
