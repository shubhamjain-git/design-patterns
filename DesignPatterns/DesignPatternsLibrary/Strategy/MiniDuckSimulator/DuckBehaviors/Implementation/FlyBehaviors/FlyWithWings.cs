using System;

namespace DesignPatternsLibrary.Strategy.MiniDuckSimulator
{
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}
