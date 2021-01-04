namespace DesignPatternsLibrary.Facade.HomeTheater
{
	public class DvdPlayer
	{
        int currentTrack;
        private readonly Amplifier amplifier;
		string movie;

        public string Description { get; }

        public DvdPlayer(string description, Amplifier amplifier)
		{
			Description = description;
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
			movie = null;
			return Description + " eject\n";
		}

		public string Play(string movie)
		{
			this.movie = movie;
			currentTrack = 0;
			return Description + " playing \"" + movie + "\"\n";
		}

		public string Play(int track)
		{
			if (movie == null)
			{
				return Description + " can't play track " + track.ToString() + " no dvd inserted\n";
			}
			else
			{
				currentTrack = track;
				return Description + " playing track " + currentTrack.ToString() + " of \"" + movie + "\"\n";
			}
		}

		public string Stop()
		{
			currentTrack = 0;
			return Description + " stopped \"" + movie + "\"\n";
		}

		public string Pause()
		{
			return Description + " paused \"" + movie + "\"\n";
		}

		public string SetTwoChannelAudio()
		{
			return Description + " set two channel audio\n";
		}

		public string SetSurroundAudio()
		{
			return Description + " set surround audio\n";
		}
	}
}
