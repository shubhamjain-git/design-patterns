namespace DesignPatternsLibrary.Facade.HomeTheater
{
	public class CdPlayer
	{
        int currentTrack;
        private readonly Amplifier amplifier;
		string title;

        public string Description { get; }

        public CdPlayer(string description, Amplifier amplifier)
		{
			this.Description = description;
			this.amplifier = amplifier;
		}

		public string On()
		{
			return Description + " on\n";
		}

		public string Off()
		{
			return Description + " off\n";
		}

		public string Eject()
		{
			title = null;
			return Description + " eject\n";
		}

		public string Play(string title)
		{
			this.title = title;
			currentTrack = 0;
			return Description + " playing \"" + title + "\"\n";
		}

		public string Play(int track)
		{
			if (title == null)
			{
				return Description + " can't play track " + currentTrack +
					", no cd inserted\n";
			}
			else
			{
				currentTrack = track;
				return Description + " playing track " + currentTrack + "\n";
			}
		}

		public string Stop()
		{
			currentTrack = 0;
			return Description + " stopped\n";
		}

		public string Pause()
		{
			return Description + " paused \"" + title + "\"\n";
		}
	}
}
