using System;

/// <summary>
/// The Strategy Pattern defines a family of algorithms, encapsulates each one
/// and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it
/// </summary>
namespace DesignPatternsLibrary.Strategy.MiniDuckSimulator
{
    public class MiniDuckSimulator : IDesignPattern
    {
        private Duck duck;

        public MiniDuckSimulator()
        {
            Console.WriteLine("!!Welcome to Mini Duck Simulator!!");
        }

        public Duck GetDuckInstance(string duckName)
        {
            switch (duckName)
            {
                case MiniDuckSimulatorConstants.MALLARD_DUCK:
                    duck = new MallardDuck();
                    break;

                case MiniDuckSimulatorConstants.REDHEAD_DUCK:
                    duck = new ReadheadDuck();
                    break;

                case MiniDuckSimulatorConstants.RUBBER_DUCK:
                    duck = new RubberDuck();
                    break;

                case MiniDuckSimulatorConstants.DECOY_DUCK:
                    duck = new DecoyDuck();
                    break;

                case MiniDuckSimulatorConstants.MODEL_DUCK:
                    duck = new ModelDuck();
                    break;

                default:
                    throw new NotImplementedException();
            }

            return duck;
        }

        public void RunExample()
        {
            Console.WriteLine("!!Mini Duck Simulator Demo!!");
            Console.WriteLine("Created an instance of Model Duck.");
            duck = new ModelDuck();
            duck.Display();
            duck.PerformFly();
            duck.PerformQuack();
            Console.WriteLine("Changing the fly behavior of Model Duck.");
            duck.SetFlyBehavior(new FlyRocketPowered());
            duck.PerformFly();
        }
    }
}
