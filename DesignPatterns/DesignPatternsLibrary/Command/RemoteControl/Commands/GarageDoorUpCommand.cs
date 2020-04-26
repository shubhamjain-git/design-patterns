namespace DesignPatternsLibrary.Command.RemoteControl
{
    public class GarageDoorUpCommand : ICommand
    {
        private readonly GarageDoor garageDoor;

        public GarageDoorUpCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            garageDoor.Up();
        }
    }
}
