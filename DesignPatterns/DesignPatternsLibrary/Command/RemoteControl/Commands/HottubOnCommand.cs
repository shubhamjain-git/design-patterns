namespace DesignPatternsLibrary.Command.RemoteControl
{
    public class HottubOnCommand : ICommand
    {
		private readonly Hottub hottub;

		public HottubOnCommand(Hottub hottub)
		{
			this.hottub = hottub;
		}

		public void Execute()
		{
			hottub.On();
			hottub.Heat();
			hottub.BubblesOn();
		}
	}
}
