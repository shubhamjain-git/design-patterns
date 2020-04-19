using System;

namespace DesignPatternsLibrary.Strategy.ActionAdventureGame
{
    public abstract class Character
    {
        protected IWeaponBehavior weapon;

        public abstract void Fight();

        public void SetWeapon(IWeaponBehavior weapon)
        {
            this.weapon = weapon;
        }

        public void UseWeapon()
        {
            if(weapon == null)
            {
                Console.WriteLine("Weapon is not set!");
                return;
            }
            weapon.UseWeapon();
        }
    }
}
