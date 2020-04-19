using System;

namespace DesignPatternsLibrary.Strategy.ActionAdventureGame
{
    public class KnifeBehavior : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Cutting with a knife!");
        }
    }
}
