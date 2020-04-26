namespace DesignPatternsLibrary.Command.RemoteControl
{
    public class HottubOffCommand : ICommand
    {
		private readonly Hottub hottub;

		public HottubOffCommand(Hottub hottub)
		{
			this.hottub = hottub;
		}

		public void Execute()
		{
			hottub.Cool();
			hottub.Off();
		}
	}
}
