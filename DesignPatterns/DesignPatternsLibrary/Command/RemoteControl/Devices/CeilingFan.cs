using System;

namespace DesignPatternsLibrary.Command.RemoteControl
{
    public class CeilingFan
    {
		private readonly string location;
		private int level;
		public const int HIGH = 2;
		public const int MEDIUM = 1;
		public const int LOW = 0;

		public CeilingFan(string location)
		{
			this.location = location;
		}

		public void High()
		{
			// turns the ceiling fan on to high
			level = HIGH;
			Console.WriteLine(location + " ceiling fan is on high");
		}

		public void Medium()
		{
			// turns the ceiling fan on to medium
			level = MEDIUM;
			Console.WriteLine(location + " ceiling fan is on medium");
		}

		public void Low()
		{
			// turns the ceiling fan on to low
			level = LOW;
			Console.WriteLine(location + " ceiling fan is on low");
		}

		public void Off()
		{
			// turns the ceiling fan off
			level = 0;
			Console.WriteLine(location + " ceiling fan is off");
		}

		public int GetSpeed()
		{
			return level;
		}
	}
}
