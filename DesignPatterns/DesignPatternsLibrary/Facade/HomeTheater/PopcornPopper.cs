namespace DesignPatternsLibrary.Facade.HomeTheater
{
	public class PopcornPopper
	{
        public string Description { get; }

        public PopcornPopper(string description)
		{
			this.Description = description;
		}

		public string On()
		{
			return Description + " on\n";
		}

		public string Off()
		{
			return Description + " off\n";
		}

		public string Pop()
		{
			return Description + " popping popcorn!\n";
		}
	}
}
