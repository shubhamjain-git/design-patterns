namespace DesignPatternsLibrary.Facade.HomeTheater
{
	public class Projector
	{
        private readonly DvdPlayer dvdPlayer;

        public string Description { get; }

        public Projector(string description, DvdPlayer dvdPlayer)
		{
			this.Description = description;
			this.dvdPlayer = dvdPlayer;
		}

		public string On()
		{
			return Description + " on\n";
		}

		public string Off()
		{
			return Description + " off\n";
		}

		public string WideScreenMode()
		{
			return Description + " in widescreen mode (16x9 aspect ratio)\n";
		}

		public string TvMode()
		{
			return Description + " in tv mode (4x3 aspect ratio)\n";
		}
	}
}
