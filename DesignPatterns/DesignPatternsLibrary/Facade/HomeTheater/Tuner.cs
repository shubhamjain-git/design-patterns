namespace DesignPatternsLibrary.Facade.HomeTheater
{
	public class Tuner
	{
        private double frequency;

        public string Description { get; }

        public Tuner(string description, Amplifier amplifier)
		{
			Description = description;
		}

		public string On()
		{
			return Description + " on\n";
		}

		public string Off()
		{
			return Description + " off\n";
		}

		public string SetFrequency(double frequency)
		{
			this.frequency = frequency;
			return Description + " setting frequency to " + frequency.ToString() + "\n";
		}

		public string SetAm()
		{
			return Description + " setting AM mode\n";
		}

		public string SetFm()
		{
			return Description + " setting FM mode\n";
		}
	}
}
