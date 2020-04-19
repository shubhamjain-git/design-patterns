using System;

/// <summary>
/// The Singleton Pattern ensures a class has only one
/// instance, and provides a global point of access to it.
/// </summary>
namespace DesignPatternsLibrary.Singleton.ChocolateBoiler
{
    public class ChocolateBoiler : IDesignPattern
    {
        private bool empty;
        private bool boiled;
        private static ChocolateBoiler uniqueInstance;
        private static readonly object syncLock = new object();

        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }

        public static ChocolateBoiler GetInstance()
        {
            if(uniqueInstance == null)
            {
                uniqueInstance = new ChocolateBoiler();
            }
            return uniqueInstance;
        }

        //By adding the lock to getInstance(), we force every thread to wait for its turn before it can enter the method.
        //That is, no two threads may enter the method at the same time
        public static ChocolateBoiler GetSynchronizedInstance()
        {
            lock (syncLock)
            {
                Console.WriteLine("This is a synchronized instance.");
                return GetInstance();
            }                
        }

        public void Fill()
        {
            if (IsEmpty())
            {
                empty = false;
                boiled = false;
                Console.WriteLine("Filled the boiler with a milk/chocolate mixture.");
            }
        }

        public void Drain()
        {
            if(!IsEmpty() && IsBoiled())
            {
                Console.WriteLine("Drained the boiled milk and chocolate.");
                empty = true;
            }
        }

        public void Boil()
        {
            if (!IsEmpty() && !IsBoiled())
            {
                Console.WriteLine("Brought the contents to a boil.");
                boiled = true;
            }
        }

        private bool IsEmpty()
        {
            return empty;
        }

        private bool IsBoiled()
        {
            return boiled;
        }
    }
}
