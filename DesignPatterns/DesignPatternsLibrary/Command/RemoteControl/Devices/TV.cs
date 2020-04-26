using System;

namespace DesignPatternsLibrary.Command.RemoteControl.Devices
{
    public class TV
    {
		private readonly string location;
		private int channel;

		public TV(string location)
		{
			this.location = location;
		}

		public void On()
		{
			Console.WriteLine(location + " TV is on");
		}

		public void Off()
		{
			Console.WriteLine(location + " TV is off");
		}

		public void SetInputChannel()
		{
			channel = 3;
			Console.WriteLine("Channel is set for VCR " + channel);
		}
	}
}
