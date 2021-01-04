namespace DesignPatternsLibrary.Facade.HomeTheater
{
	public class TheaterLights
	{
        public string Description { get; }

        public TheaterLights(string description)
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

		public string Dim(int level)
		{
			return Description + " dimming to " + level + "%\n";
		}
	}
}
