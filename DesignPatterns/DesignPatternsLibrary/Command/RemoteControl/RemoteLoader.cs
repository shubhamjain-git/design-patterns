using System;

namespace DesignPatternsLibrary.Command.RemoteControl
{
    public class RemoteLoader : IDesignPattern
    {
		private RemoteControl remoteControl;

        public RemoteLoader()
        {
			remoteControl = new RemoteControl();

			Light livingRoomLight = new Light(RemoteControlConstants.LIVING_ROOM);
			Light kitchenLight = new Light(RemoteControlConstants.KITCHEN);
			CeilingFan ceilingFan = new CeilingFan(RemoteControlConstants.LIVING_ROOM);
			GarageDoor garageDoor = new GarageDoor();
			Stereo stereo = new Stereo(RemoteControlConstants.LIVING_ROOM);

			LightOnCommand livingRoomLightOn =
					new LightOnCommand(livingRoomLight);
			LightOffCommand livingRoomLightOff =
					new LightOffCommand(livingRoomLight);

			LightOnCommand kitchenLightOn =
					new LightOnCommand(kitchenLight);
			LightOffCommand kitchenLightOff =
					new LightOffCommand(kitchenLight);

			CeilingFanOnCommand ceilingFanOn =
					new CeilingFanOnCommand(ceilingFan);
			CeilingFanOffCommand ceilingFanOff =
					new CeilingFanOffCommand(ceilingFan);

			GarageDoorUpCommand garageDoorUp =
					new GarageDoorUpCommand(garageDoor);
			GarageDoorDownCommand garageDoorDown =
					new GarageDoorDownCommand(garageDoor);

			StereoOnWithCDCommand stereoOnWithCD =
					new StereoOnWithCDCommand(stereo);
			StereoOffCommand stereoOff =
					new StereoOffCommand(stereo);

			remoteControl.SetCommand(0, livingRoomLightOn, livingRoomLightOff);
			remoteControl.SetCommand(1, kitchenLightOn, kitchenLightOff);
			remoteControl.SetCommand(2, ceilingFanOn, ceilingFanOff);
			remoteControl.SetCommand(3, stereoOnWithCD, stereoOff);
			remoteControl.SetCommand(4, garageDoorUp, garageDoorDown);

			Console.WriteLine(remoteControl);
		}

		public RemoteControl GetInstance()
		{
			if (remoteControl == null)
				remoteControl = new RemoteControl();
			return remoteControl;
		}

		public void RunExample()
		{
			remoteControl.OnButtonWasPushed(0);
			remoteControl.OffButtonWasPushed(0);
			remoteControl.OnButtonWasPushed(1);
			remoteControl.OffButtonWasPushed(1);
			remoteControl.OnButtonWasPushed(2);
			remoteControl.OffButtonWasPushed(2);
			remoteControl.OnButtonWasPushed(3);
			remoteControl.OffButtonWasPushed(3);
		}
	}
}
