namespace DesignPatternsLibrary.Command.RemoteControl
{
    public class CeilingFanOffCommand : ICommand
    {
		private readonly CeilingFan ceilingFan;

		public CeilingFanOffCommand(CeilingFan ceilingFan)
		{
			this.ceilingFan = ceilingFan;
		}

		public void Execute()
		{
			ceilingFan.Off();
		}
	}
}
