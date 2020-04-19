using System;

namespace DesignPatternsLibrary.Strategy.ActionAdventureGame
{
    public class King : Character
    {
        public King()
        {
            weapon = new SwordBehavior();
        }

        public override void Fight()
        {
            Console.WriteLine("The King is flighting!");
        }
    }
}
