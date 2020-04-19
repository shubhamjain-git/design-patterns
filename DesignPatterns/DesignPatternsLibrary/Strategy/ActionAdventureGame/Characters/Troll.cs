using System;

namespace DesignPatternsLibrary.Strategy.ActionAdventureGame
{
    public class Troll : Character
    {
        public Troll()
        {
            weapon = new AxeBehavior();
        }

        public override void Fight()
        {
            Console.WriteLine("The Troll is fighting!");
        }
    }
}
