using System;

namespace DesignPatternsLibrary.Command.RemoteControl
{
    public class Light
    {
        private readonly string location;

        public Light(string location)
        {
            this.location = location;
        }

        public void On()
        {
            Console.WriteLine(location + " light is on");
        }

        public void Off()
        {
            Console.WriteLine(location + " light is off");
        }
    }
}
