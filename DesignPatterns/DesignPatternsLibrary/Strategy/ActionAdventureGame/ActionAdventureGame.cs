using System;

namespace DesignPatternsLibrary.Strategy.ActionAdventureGame
{
    public class ActionAdventureGame : IDesignPattern
    {
        private Character character;

        public ActionAdventureGame()
        {
            Console.WriteLine("!!Action Adventure Game!!");
        }

        public Character GetCharacter(string characterName)
        {
            switch (characterName)
            {
                case ActionAdventureGameConstants.KING:
                    character = new King();
                    break;

                case ActionAdventureGameConstants.QUEEN:
                    character = new Queen();
                    break;

                case ActionAdventureGameConstants.KNIGHT:
                    character = new Knight();
                    break;

                case ActionAdventureGameConstants.TROLL:
                    character = new Troll();
                    break;

                default:
                    throw new NotImplementedException();
            }
            return character;
        }
    }
}
