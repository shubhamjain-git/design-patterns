namespace DesignPatternsLibrary.Command.RemoteControl
{
    public class GarageDoorDownCommand : ICommand
    {
        private readonly GarageDoor garageDoor;

        public GarageDoorDownCommand(GarageDoor garageDoor)
        {
            this.garageDoor = garageDoor;
        }

        public void Execute()
        {
            garageDoor.Down();
        }
    }
}
