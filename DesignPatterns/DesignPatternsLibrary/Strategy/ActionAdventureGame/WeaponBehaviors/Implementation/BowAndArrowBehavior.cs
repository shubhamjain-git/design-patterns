using System;

namespace DesignPatternsLibrary.Strategy.ActionAdventureGame
{
    public class BowAndArrowBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Shooting an arrow with a bow!");
        }
    }
}
