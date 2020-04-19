using System;

namespace DesignPatternsLibrary.Strategy.MiniDuckSimulator
{
    public abstract class Duck
    {
        protected IFlyBehavior flyBehavior;
        protected IQuackBehavior quackBehavior;

        public void Swim()
        {
            Console.WriteLine("I'm, swimming!");
        }

        public abstract void Display();

        public void PerformQuack()
        {
            if (quackBehavior == null)
            {
                Console.WriteLine("QuackBehavior is not set!");
                return;
            }
            quackBehavior.Quack();
        }

        public void PerformFly()
        {
            if (flyBehavior == null)
            {
                Console.WriteLine("FlyBehavior is not set!");
                return;
            }
            flyBehavior.Fly();
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            this.flyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            this.quackBehavior = quackBehavior;
        }
    }
}
