using System;

namespace DesignPatternsLibrary.Strategy.MiniDuckSimulator
{
    public class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I can't quack!");
        }
    }
}
