namespace DesignPatternsLibrary.Facade.HomeTheater
{
	public class Amplifier
	{
        private Tuner tuner;
        private DvdPlayer dvd;
        private CdPlayer cd;

        public string Description { get; }

        public Amplifier(string description)
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

		public string SetStereoSound()
		{
			return Description + " stereo mode on\n";
		}

		public string SetSurroundSound()
		{
			return Description + " surround sound on (5 speakers, 1 subwoofer)\n";
		}

		public string SetVolume(int level)
		{
			return Description + " setting volume to " + level + "\n";
		}

		public string SetTuner(Tuner tuner)
		{
			this.tuner = tuner;
			return Description + " setting tuner to " + tuner.Description + "\n";
		}

		public string SetDvd(DvdPlayer dvd)
		{
			this.dvd = dvd;
			return Description + " setting DVD player to " + dvd.Description + "\n";
		}

		public string SetCd(CdPlayer cd)
		{
			this.cd = cd;
			return Description + " setting CD player to " + cd.Description + "\n";
		}
	}
}
