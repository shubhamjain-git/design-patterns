namespace DesignPatternsLibrary.Command.RemoteControl
{
    public class CeilingFanOnCommand : ICommand
    {
		private readonly CeilingFan ceilingFan;

		public CeilingFanOnCommand(CeilingFan ceilingFan)
		{
			this.ceilingFan = ceilingFan;
		}

		public void Execute()
		{
			ceilingFan.Medium();
		}
	}
}
