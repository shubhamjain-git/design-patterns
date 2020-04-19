using System;

namespace DesignPatternsLibrary.Strategy.ActionAdventureGame
{
    public class Queen : Character
    {
        public Queen()
        {
            weapon = new BowAndArrowBehavior();
        }

        public override void Fight()
        {
            Console.WriteLine("The Queen is fighting!");
        }
    }
}
