using System;

namespace DesignPatternsLibrary.Strategy.MiniDuckSimulator
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I'm squeaking!");
        }
    }
}
