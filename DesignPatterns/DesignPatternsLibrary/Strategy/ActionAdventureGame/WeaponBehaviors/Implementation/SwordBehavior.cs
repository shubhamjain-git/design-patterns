using System;

namespace DesignPatternsLibrary.Strategy.ActionAdventureGame
{
    public class SwordBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Swinging a sword!");
        }
    }
}
