using System;

namespace DesignPatternsLibrary.Strategy.ActionAdventureGame
{
    public class AxeBehavior : IWeaponBehavior
    { 
        public void UseWeapon()
        {
            Console.WriteLine("Chopping with an axe!");
        }
    }
}
