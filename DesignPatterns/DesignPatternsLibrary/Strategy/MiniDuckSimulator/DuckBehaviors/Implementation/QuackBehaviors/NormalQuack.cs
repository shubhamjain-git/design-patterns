using System;

namespace DesignPatternsLibrary.Strategy.MiniDuckSimulator
{
    public class NormalQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("I'm quacking!");
        }
    }
}
