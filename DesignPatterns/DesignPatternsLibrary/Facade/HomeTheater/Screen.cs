namespace DesignPatternsLibrary.Facade.HomeTheater
{
	public class Screen
	{
        public string Description { get; }

        public Screen(string description)
		{
			Description = description;
		}

		public string Up()
		{
			return Description + " going up\n";
		}

		public string Down()
		{
			return Description + " going down\n";
		}
	}
}
