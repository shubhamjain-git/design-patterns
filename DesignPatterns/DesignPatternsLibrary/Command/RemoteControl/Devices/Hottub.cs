using System;

namespace DesignPatternsLibrary.Command.RemoteControl
{
    public class Hottub
    {
		private bool on;
		private int temperature;

		public Hottub()
		{
		}

		public void On()
		{
			on = true;
		}

		public void Off()
		{
			on = false;
		}

		public void BubblesOn()
		{
			if (on)
			{
				Console.WriteLine("Hottub is bubbling!");
			}
		}

		public void BubblesOff()
		{
			if (on)
			{
				Console.WriteLine("Hottub is not bubbling");
			}
		}

		public void JetsOn()
		{
			if (on)
			{
				Console.WriteLine("Hottub jets are on");
			}
		}

		public void JetsOff()
		{
			if (on)
			{
				Console.WriteLine("Hottub jets are off");
			}
		}

		public void SetTemperature(int temperature)
		{
			this.temperature = temperature;
		}

		public void Heat()
		{
			temperature = 105;
			Console.WriteLine("Hottub is heating to a steaming " + temperature + " degrees");
		}

		public void Cool()
		{
			temperature = 98;
			Console.WriteLine("Hottub is cooling to " + temperature + " degrees");
		}

	}
}
