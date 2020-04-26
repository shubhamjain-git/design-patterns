namespace DesignPatternsLibrary.Command.RemoteControl
{
    public class LightOffCommand : ICommand
    {
        private readonly Light light;

        public LightOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.Off();
        }
    }
}
