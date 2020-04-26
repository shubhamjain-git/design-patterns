using System;

namespace DesignPatternsLibrary.Command.RemoteControl
{
    public class GarageDoor
    {
		public void Up()
		{
			Console.WriteLine("Garage Door is Up");
		}

		public void Down()
		{
			Console.WriteLine("Garage Door is Down");
		}

		public void Stop()
		{
			Console.WriteLine("Garage Door is Stopped");
		}

		public void LightOn()
		{
			Console.WriteLine("Garage light is on");
		}

		public void LightOff()
		{
			Console.WriteLine("Ggarage light is off");
		}
	}
}
