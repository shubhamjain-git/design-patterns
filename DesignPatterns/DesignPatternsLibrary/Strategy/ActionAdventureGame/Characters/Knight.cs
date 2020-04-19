using System;

namespace DesignPatternsLibrary.Strategy.ActionAdventureGame
{
    public class Knight : Character
    {
        public Knight()
        {
            weapon = new KnifeBehavior();
        }

        public override void Fight()
        {
            Console.WriteLine("The Knight is fighting!");
        }
    }
}
